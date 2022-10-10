using Microsoft.EntityFrameworkCore.Metadata.Internal;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace projeto_crud.Models
{
    [Table("Usuario")]
    public class Usuario

    {

        [Display(Name = "Codigo")]
        [Column("id")]
        public int id { get; set; }

        [Display(Name = "nome")]
        [Column("nome")]
        public string nome { get; set; }

        [Display(Name = "email")]
        [Column("email")]
        public string email { get; set; }

        [Display(Name = "senha")]
        [Column("senha")]
        public string senha { get; set; }
    }
}
