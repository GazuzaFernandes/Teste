using System;
using System.Collections.Generic;
using System.Text;

namespace DALLogistica.Entities
{
    public class montagem
    {
        public virtual int montagemid { get; set; }
        public virtual string montador { get; set; }
        public virtual DateTime dataenvio { get; set; }
        public virtual string obra { get; set; }
        public virtual string material { get; set; }
        public virtual int statusobraid { get; set; }
    }
}
