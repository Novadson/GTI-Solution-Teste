
using Projeto_API.Enum;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Projeto_API.Entities
{
    [Table("cliente")]
    public class Cliente
    {
        #region PROPERTIES
        [Key]
        [Column("id_cliente")]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public Guid IdCliente { get; set; }

        [Column("nome", TypeName = "VARCHAR")]
        [StringLength(1000)]
        public string Nome { get; set; }

        [Column("cpf", TypeName = "VARCHAR")]
        [StringLength(1000)]
        public string Cpf { get; set; }

        [StringLength(25)]
        [Column("rg", TypeName = "VARCHAR")]
        public string Rg { get; set; }

        [Column("data_expedicao")]
        public DateTime DataExpedicao { get; set; } = DateTime.Now;

        [Column("data_nascimento")]
        public DateTime DataNascimento { get; set; }

        [Column("orgao_expedicao_value")]
        public OrgaosExpedidores OrgaoExpedicaoValue { get; set; }

        [Column("orgao_expedicao_desc")]
        public string OrgaoExpedicaoDesc { get; set; }


        [Column("sexo_value")]
        public Sexos SexoValue { get; set; }

        [Column("sexo_desc")]
        public string SexoDesc { get; set; }

        [Column("estado_civil_value")]
        public EstadosCivis EstadoCivilValue { get; set; }

        [Column("estado_civil_desc")]
        public string EstadoCivilDesc { get; set; }

        //[Column("estado_civil")]
        //public EstadosCivis EstadoCivil { get; set; }
        #endregion PROPERTIES

        [NotMapped]
        public EnderecoCliente Endereco { get; set; }

    }
}
