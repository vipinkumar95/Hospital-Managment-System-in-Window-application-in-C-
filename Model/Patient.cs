using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PranjulMedicalCenter.Model
{
    public class Patient :CommanProps
    {

        public int PatientId { get; set; }

        public string Name { get; set; }

        public string Address { get; set; } 

        public string Contact { get; set; }

        public int Age { get; set; }

        public string Gender { get; set; }

        public string BloodGroup { get; set; }

        public string PCode { get; set; }

        public int DoctorId { get; set; }

        public string DoctorName { get; set; }
    }
}
