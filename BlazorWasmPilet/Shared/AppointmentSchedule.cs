using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlazorWasmPilet.Shared
{
    public class AppointmentSchedule
    {
        public int ScheduleId { get; set; }

        public int PatientId { get; set; }

        public int HealthCarePractitionerId { get; set; }

        public DateTime AppointmentDate { get; set; }

    }
}
