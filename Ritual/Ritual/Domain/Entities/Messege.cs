using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ritual.Domain.Entities
{
    public class Messege : EntityBase

    {

        public string Name { get; set; }
        public string NumberPhone { get; set; }
          
        public string FullMessege { get; set; }
        public DateTime TimeMess { get; set; }


    }
}
