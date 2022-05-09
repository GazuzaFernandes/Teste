using DALLogistica.Entities;
using FluentNHibernate.Mapping;

namespace DALLogistica.Mapping
{
    public class cadastrarempresaMap : ClassMap<cadastrarempresa>
    {
        public cadastrarempresaMap()
        {
            Id(p => p.empresaid).GeneratedBy.Sequence("cadastrarempresa_seq");
            Map(p => p.empresa);
            Map(p => p.cliente);
            Map(p => p.construtora);         
            Table("cadastrarempresa");
        }

    }
}
