using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DALLogistica.Entities
{
    public class cadastrarmadeira
    {
        public virtual int madeiraid { get; set; }  
        public virtual string pisomadeira { get; set; }
        public virtual string comprimentos { get; set; }
        public virtual decimal m2caixa { get; set; }
    }
}
