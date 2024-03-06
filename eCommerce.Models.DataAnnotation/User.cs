using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace eCommerce.Models
{
    [Table("TB_USUARIOS")]
    public class User
    {
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int Id { get; set; }

        //[Key]
        //[Column("COD")]
        //public int Code { get; set; }

        public string Name { get; set; } = null!;
        public string Email { get; set; } = null!;
        public string? Sex { get; set; }

        [Column("REGISTRO_GERAL")]
        public string? RG {  get; set; }

        public string CPF { get; set; } = null!;
        public string? NomeMae { get; set; }
        public string? RegisterSituation { get; set; }

        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Registration { get; set; }

        [NotMapped]
        public DateTimeOffset RegisterDate { get; set; }

        [ForeignKey("UsuarioId")]
        public Contact? Contact { get; set; }
        public ICollection<SendAddress>? SendAddresses { get; set; }
        public ICollection<Department>? Departments { get; set; }
    }
}
