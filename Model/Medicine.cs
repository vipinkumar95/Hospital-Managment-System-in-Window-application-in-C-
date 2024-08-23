using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PranjulMedicalCenter.Model
{
    public class Medicine : CommanProps
    {
        public int MedicineId { get; set; }

        public string MedicineName { get; set; }

        public int DianosisId { get; set; }

        public int PatientId { get; set; }
    }
}
