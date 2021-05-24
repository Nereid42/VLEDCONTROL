using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VLEDCONTROL
{
   public class PropertyDataHandler : DataHandler
   {
      public PropertyDataHandler(Engine engine) : base(engine)
      {

      }

      public override void ProcessData(string id, string value)
      {
         try
         {
            int numeric_id = int.Parse(id);
            if(numeric_id < 1000)
            {
               double numeric_value = double.Parse(value);
               engine.SetProperty(numeric_id, numeric_value);
            }
         }
         catch(Exception e)
         {
            LogError("Execption caught for id='"+id+"', value='"+value+"'");
            LogException(e);
         }
      }
   }
}
