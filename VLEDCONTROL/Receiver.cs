/*
 * MIT License

Copyright (c) 2021 Nereid

Permission is hereby granted, free of charge, to any person obtaining a copy
of this software and associated documentation files (the "Software"), to deal
in the Software without restriction, including without limitation the rights
to use, copy, modify, merge, publish, distribute, sublicense, and/or sell
copies of the Software, and to permit persons to whom the Software is
furnished to do so, subject to the following conditions:

The above copyright notice and this permission notice shall be included in all
copies or substantial portions of the Software.

THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND, EXPRESS OR
IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES OF MERCHANTABILITY,
FITNESS FOR A PARTICULAR PURPOSE AND NONINFRINGEMENT. IN NO EVENT SHALL THE
AUTHORS OR COPYRIGHT HOLDERS BE LIABLE FOR ANY CLAIM, DAMAGES OR OTHER
LIABILITY, WHETHER IN AN ACTION OF CONTRACT, TORT OR OTHERWISE, ARISING FROM,
OUT OF OR IN CONNECTION WITH THE SOFTWARE OR THE USE OR OTHER DEALINGS IN THE
SOFTWARE.
*/
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net;
using System.Net.Sockets;
using System.Collections;
using System.Threading;

namespace VLEDCONTROL
{
   public class Receiver : Loggable
   {
      public volatile bool _IsRunning = false;

      public bool IsRunning { get { return _IsRunning; } set { _IsRunning = value; } }


   private UdpClient Client;
      private volatile bool StopRequest;
      private readonly List<DataHandler> handler;

      private readonly int Port;


      public Receiver(int port)
      {
         LogInfo("Creating UDP receiver for Port " + port);
         this.Port = port;
         this.StopRequest = false;
         this.handler = new List<DataHandler>();
      }

      public void Start()
      {
         if (IsRunning)
         {
            LogWarning("Receiver is still runing.");
         }
         this.StopRequest = false;
         Thread t = new Thread(new ThreadStart(this.Run));
         t.IsBackground = true;
         LogInfo("Starting Receiver thread");
         t.Start();
      }

      public void Stop()
      {
         LogInfo("Stoprequest for Receiver");
         this.StopRequest = true;
      }

      public void AddDataHandler(DataHandler handler)
      {
         this.handler.Add(handler);
      }

      private byte[] ReceiveBytes(ref IPEndPoint endpoint)
      {
         Byte[] bytes = new byte[0];
         while (!StopRequest)
         {
            try
            {
               bytes = Client.Receive(ref endpoint);
               break;
            }
            catch (SocketException)
            {
               // nothing to do
               // we are just catching the Timeout
            }
         }
         return bytes;
      }

      private String Receive(ref IPEndPoint endpoint)
      {
         StringBuilder sb = new StringBuilder();
         try
         {
            while (!StopRequest)
            {
               // Blocks until a message returns on this socket from a remote host.
               LogDebug("waiting for data to receive...");
               byte[] bytes = ReceiveBytes(ref endpoint);
               String data = Encoding.ASCII.GetString(bytes);
               LogTrace("data received, " + bytes.Length + " bytes");
               LogDebug("Data received '" + data+"'");
               LogTrace("From " + endpoint.Address.ToString() + " on their port " + endpoint.Port.ToString());

               sb.Append(data);

               if (data.EndsWith("/STOP")) break;
            }
         }
         catch (Exception e)
         {
            LogInfo(e.ToString());
         }

         return sb.ToString();
      }

      private void Run()
      {
         LogInfo("starting UDP receiver...");
         //
         try
         {
            this.Client = new UdpClient(Port);
            this.Client.Client.ReceiveTimeout = 200;
         }
         catch(Exception e)
         {
            LogError("failed to create UDP Client");
            LogException(e);
            return;
         }

         IsRunning = true;

         IPEndPoint RemoteIpEndPoint = new IPEndPoint(IPAddress.Any, 0);

         while (!this.StopRequest)
         {
            try
            {
               String data = Receive(ref RemoteIpEndPoint);

               LogDebug("calling " + this.handler.Count + " data handler...");
               foreach (DataHandler handler in this.handler)
               {
                  handler.HandleData(data);
               }

            }
            catch (Exception e)
            {
               LogInfo(e.ToString());
            }
         }

         Client.Close();
         LogInfo("UDP Receiver stopped");
         IsRunning = false;
      }

      internal void Join()
      {
         LogDebug("Waiting for receiver to stop...");
         while(IsRunning)
         {
            Thread.Sleep(100);
         }
         LogDebug("Receiver is stopped");
      }
   }
}
