using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlazorWasmPilet.Shared
{
    public class HealthCareProvider
    {
        public int ProviderId { get; set; }

        public string Name { get; set; }

        public string? Description { get; set; }

        public string PhoneNumber { get; set; }    

        public string location { get; set; }

    }
}
