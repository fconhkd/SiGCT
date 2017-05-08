using SiGCT.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SiGCT.Data.EF.Mappings
{
    public class ContaMap : EntityTypeConfiguration<Conta>
    {
        public ContaMap()
        {
            ToTable("Conta", "dbo");

            HasKey(x => x.Id);

            //Property(x => x.Tipo).HasMaxLength(15);
            //Property(x => x.PrePago);
            //Property(x => x.Localizacao).HasMaxLength(50);
            //Property(x => x.CobrancaId);
            //Property(x => x.CobrancaOrigemId);
            //Property(x => x.Situacao).HasMaxLength(50);
            //Property(x => x.DataPagto).HasColumnType("Date");
            //Property(x => x.Integradora).HasMaxLength(15);

            //Property(x => x.NossoNumero).HasMaxLength(20);
            //Property(x => x.RetornoId).HasMaxLength(80);
            //Property(x => x.Empresa).HasMaxLength(3);
            //Property(x => x.Banco).HasMaxLength(15);
            //Property(x => x.Carteira).HasMaxLength(15);
            //Property(x => x.Agencia).HasMaxLength(15);
            //Property(x => x.ContaCorrente).HasMaxLength(15);

            //Property(x => x.Status);
            //Property(x => x.Msg).HasMaxLength(255);

            //Property(x => x.DataInclusao).IsRequired();
            //Property(x => x.DataAlteracao);
        }
    }
}
