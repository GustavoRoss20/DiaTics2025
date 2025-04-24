namespace Domain.Entities
{
    public class AlumnoEtd
    {
        //NumeroControl varchar	10	no
        public string NumeroControl { get; set; } = string.Empty;

        //Nombre  varchar	50	no
        public string Nombre { get; set; } = string.Empty;

        //ApellidoPaterno varchar	50	no
        public string ApellidoPaterno { get; set; } = string.Empty;

        //ApellidoMaterno varchar	50	no
        public string ApellidoMaterno { get; set; } = string.Empty;

        //Carrera varchar	50	no
        public string Carrera { get; set; } = string.Empty;

        //RegistradoParaEvento    bit	1	no
        public bool RegistradoParaEvento { get; set; }

        //FechaRegistro   datetime	8	yes
        public DateTime? FechaRegistro { get; set; }
    }
}
