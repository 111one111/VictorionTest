using PagedList.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace NetVet.Models
{
    public class SearchData {
        public string DateTime { get; set; }
        public string PetName { get; set; }
        public string OwnersName { get; set; }
        public string Contact { get; set; }
        public IPagedList<AppointmentDetails> AppointmentDetails { get; set; }
    }
    public class AppointmentDetails
    {
        public DateTime Appointment { get; set; }

        public string PetName { get; set; }

        public string OwnersName { get; set; }
        public string PreferedContactDetails { get; set; }
    }
}
