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
         LogTrace("Handle data: " + data);
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
