using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VLEDCONTROL
{

   public class EstablishCommunicationDataHandler : DataHandler
   {
      public EstablishCommunicationDataHandler(Engine engine) : base(engine)
      {

      }
      public override void ProcessData(String id, String value)
      {
         if (id == "9999")
         {
            LogDebug("CONNECTED");
            engine.Connect();
         }
      }

   }
}
