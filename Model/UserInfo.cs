using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PranjulMedicalCenter.Model
{
    public class UserInfo :CommanProps
    {
        public int UserId { get; set; }

        public string UserName { get; set; }

        public string UserPassword { get; set; }

        public int UserType{ get; set; }

        public int DoctorId { get; set; }
    }
}
