using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PatientModelBinding.Models
{
    public class Patient
    {
        public int PatientId { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public bool IsDischarged { get; set; }
    }
}
