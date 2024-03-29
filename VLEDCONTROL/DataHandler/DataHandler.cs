﻿/* written 2021 by Nereid
  
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

namespace VLEDCONTROL
{
   public abstract class DataHandler : Loggable
   {
      protected readonly Engine engine;

      public DataHandler(Engine engine)
      {
         this.engine = engine;
      }

      public abstract void ProcessData(String id, String value);


      public void HandleData(String data)
      {
         if(IsLoggable(LEVEL.TRACE)) LogTrace("Handle data: " + data);
         String[] dataComponents = data.Split('/');
         foreach (String component in dataComponents)
         {
            if (component == "STOP") break;
            if (component != null && component.Length > 0)
            {
               String[] v = component.Split(':');
               if (v != null && v.Length == 2)
               {
                  try
                  {
                     String id = v[0];
                     String value = v[1];
                     LogDebug("process data id="+id+" / value="+value);
                     ProcessData(id, value);
                  }
                  catch (Exception e)
                  {
                     LogException(e);
                  }
               }
               else 
               {
                  LogWarning("invalid data component: '" + component + "'");
               }
            }
         }

      }
   }
}
