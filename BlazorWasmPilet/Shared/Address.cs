using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlazorWasmPilet.Shared
{
    public class Address
    {
        public string Location { get; set; }    

        public string City { get; set; }    

        public string State {  get; set; }

        public int ZipCode { get; set; }
    }
}
