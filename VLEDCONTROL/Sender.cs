/* written 2021 by Nereid
  
 Apache 2.0 License
 (see LICENSE file)

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

namespace VLEDCONTROL
{
   class Sender : Loggable
   {
      private readonly UdpClient Client;
      private readonly int port;

      public Sender(int port)
      {
         LogInfo("Creating UDP sender");
         this.Client = new UdpClient();
         this.port = port;
         this.Client.Client.ReceiveTimeout = 200;
      }

      public void Send(String data)
      {
         Byte[] bytes = Encoding.ASCII.GetBytes(data);
         UdpClient Client = new UdpClient();
         try
         {
            Client.Connect("localhost", port);
            Client.Send(bytes, bytes.Length);
         }
         catch (Exception e)
         {
            LogException(e);
         }
         finally
         {
            Client.Close();
         }
      }
   }
}
