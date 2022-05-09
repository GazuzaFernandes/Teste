using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DALLogistica.Entities
{
   public class cadastrarempresa
    {
        public virtual int empresaid { get; set; }    
        public virtual string empresa { get; set; }        
        public virtual string construtora { get; set; }
        public virtual string cliente { get; set; }

    }
}
