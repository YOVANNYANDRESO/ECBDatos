using System.ComponentModel.DataAnnotations;

namespace ECBDatos.git.DAL.Entities
{
    public class Entity
    {
        [Key]
        [Required]//equivale a un not null
        public Guid id { get; set; }
        [Display(Name = "Fecha de creacion")]//este name es el nombre o como lo quiero mostras al usuario
        public DateTime? CratedDate { get; set; }
        [Display(Name = "Fecha de modificacion")]
        public DateTime? ModifiedDate { get; set; }
    }
}
