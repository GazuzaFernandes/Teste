using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DALLogistica.Entities
{
    public class Ferramentas
    {
        public virtual int ferramentaid { get; set; }
        public virtual string funcionario { get; set; }
        public virtual DateTime retirada { get; set; }
        public virtual DateTime devolucao { get; set; }
        public virtual string material { get; set; }
        public virtual int statusobraid { get; set; }
    }
}
