using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlazorWasmPilet.Shared
{
    public class HealthCarePractitioner
    {
        public int PractitionerId { get; set; }

        public string Name { get; set; }

        public int ProviderId { get; set; }   

        public string Designation { get; set; }        
    }
}
