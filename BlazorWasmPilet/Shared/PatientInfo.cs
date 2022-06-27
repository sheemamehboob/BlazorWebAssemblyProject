using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlazorWasmPilet.Shared
{
    public class PatientInfo
    {
        public int PatientId { get; set; }

        public string PatientLastName { get; set; }

        public string PatientFirstName { get; set; }

        public string Email { get; set; }

        public string Gender { get; set; }

        public int Age { get; set; }

        public string PhoneNumber { get; set; }
      
    }
}
