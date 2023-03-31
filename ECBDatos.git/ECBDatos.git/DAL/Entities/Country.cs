using System.ComponentModel.DataAnnotations;

namespace ECBDatos.git.DAL.Entities
{
    public class Country:Entity
    {
        [Display(Name ="Pais")]
        [MaxLength(50,ErrorMessage ="El campo {0} debe ser de {1} caracteres")]//Tamaño del texto, ademas indico con parametros que el campo 0 que es Name debe ir maximo hasta el valor del {1} que es el maxlenght
        [Required(ErrorMessage ="El campo pais es obligatorio")]//le indico al usuario que este campo debe ser obligatorio
        public String Name { get; set; }
    }
}
