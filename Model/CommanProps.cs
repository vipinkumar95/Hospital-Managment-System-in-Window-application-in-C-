using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PranjulMedicalCenter.Model
{
    public class CommanProps
    {
        public DateTime? AddedDate { get; set; } =  null;

        public int AddedBy { get; set; } = 0;
        public DateTime? UpdatedDate { get; set; } = null ;

        public int UpdatedBy { get; set;} = 0;
    }
}
