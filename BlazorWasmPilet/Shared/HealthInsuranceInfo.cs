using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlazorWasmPilet.Shared
{
    public class HealthInsuranceInfo
    {
        public int InsuranceId { get; set; }

        public string ProviderName { get; set; }

        public DateTime StartDate { get; set; }

        public DateTime EndDate { get; set; }

        public int InsuranceControlId { get; set; }
        
    }
}
