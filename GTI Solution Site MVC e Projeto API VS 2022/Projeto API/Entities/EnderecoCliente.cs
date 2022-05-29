using Projeto_API.Enum;
using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Projeto_API.Entities
{
    [Table("endereco_cliente")]
    public class EnderecoCliente
    {

        #region PROPERTIES
        [Key]
        [Column("id_endereco_cliente")]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public Guid IdEnderecoCliente { get; set; }

        [Column("cep", TypeName = "VARCHAR")]
        [StringLength(1000)]
        public string Cep { get; set; }

        [Column("numero", TypeName = "VARCHAR")]
        [StringLength(1000)]
        public string Numero { get; set; }

        [Column("complemento", TypeName = "VARCHAR")]
        [StringLength(1000)]
        public string Complemento { get; set; }

        [Column("bairro")]
        [StringLength(1000)]
        public string Bairro { get; set; }

        [Column("rua")]
        [StringLength(1000)]
        public string Rua { get; set; }

        [Column("cidade", TypeName = "VARCHAR")]
        [StringLength(250)]
        public string Cidade { get; set; }

        [Column("uf_value")]
        [EnumDataType(typeof(Estados))]
        public Estados EstadoValue { get; set; }

        [Column("uf_desc")]
        [EnumDataType(typeof(Estados))]
        public string EstadoDesc { get; set; }
        #endregion PROPERTIES

        #region FOREIGNKEY
        [ForeignKey("id_cliente")]
        [Column("id_cliente")]
        public Guid IdCliente { get; set; }
        #endregion FOREIGNKEY
        #region NOTMAPPED
        [NotMapped]
        public Cliente Cliente { get; set; }

        #endregion NOTMAPPED

    }
}
