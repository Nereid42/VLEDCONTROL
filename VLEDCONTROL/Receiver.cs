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
      public Receiver(int port)
      {
         LogInfo("Creating UDP receiver for Port " + port);
         this.udpClient = new UdpClient(port);
         this.udpClient.Client.ReceiveTimeout = 200;
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
         this.StopRequest =  true;
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
               bytes = udpClient.Receive(ref endpoint);
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
            while (true)
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

         udpClient.Close();
         LogInfo("UDP Receiver stopped");
         IsRunning = false;
      }

      public volatile bool IsRunning = false;

      readonly UdpClient udpClient;
      private volatile bool StopRequest;
      private readonly List<DataHandler> handler;
   }
}
