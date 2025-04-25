using System.ComponentModel.DataAnnotations;

namespace Domain.Entities
{
    public class AlumnoEtd
    {
        //NumeroControl varchar	10	no
        [Display(Name = "Número de control")]
        [Required(ErrorMessage = "El valor para '{0}' es necesario.")]
        [MaxLength(10, ErrorMessage = "El valor para '{0}' debe tener máximo '{1}' caracteres.")]
        public string NumeroControl { get; set; } = string.Empty;

        //Nombre  varchar	50	no
        [Display(Name = "Nombre")]
        [Required(ErrorMessage = "El valor para '{0}' es necesario.")]
        [MaxLength(50, ErrorMessage = "El valor para '{0}' debe tener máximo '{1}' caracteres.")]
        public string Nombre { get; set; } = string.Empty;

        //ApellidoPaterno varchar	50	no
        [Display(Name = "Apellido paterno")]
        [Required(ErrorMessage = "El valor para '{0}' es necesario.")]
        [MaxLength(50, ErrorMessage = "El valor para '{0}' debe tener máximo '{1}' caracteres.")]
        public string ApellidoPaterno { get; set; } = string.Empty;

        //ApellidoMaterno varchar	50	no
        [Display(Name = "Apellido materno")]
        [Required(ErrorMessage = "El valor para '{0}' es necesario.")]
        [MaxLength(50, ErrorMessage = "El valor para '{0}' debe tener máximo '{1}' caracteres.")]
        public string ApellidoMaterno { get; set; } = string.Empty;

        //Carrera varchar	50	no
        [Display(Name = "Carrera")]
        [Required(ErrorMessage = "El valor para '{0}' es necesario.")]
        [MaxLength(50, ErrorMessage = "El valor para '{0}' debe tener máximo '{1}' caracteres.")]
        public string Carrera { get; set; } = string.Empty;

        //RegistradoParaEvento    bit	1	no
        public bool RegistradoParaEvento { get; set; }

        //FechaRegistro   datetime	8	yes
        public DateTime? FechaRegistro { get; set; }
    }
}
