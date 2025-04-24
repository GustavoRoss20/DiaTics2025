namespace Domain.Entities
{
    public class InvitadoEtd
    {
        //Id int	4	no
        public int Id { get; set; }

        //Nombre  varchar	100	no
        public string Nombre { get; set; } = string.Empty;

        //ApellidoPaterno varchar	50	no
        public string ApellidoPaterno { get; set; } = string.Empty;

        //ApellidoMaterno varchar	50	no
        public string ApellidoMaterno { get; set; } = string.Empty;

        //Escuela varchar	100	no
        public string Escuela { get; set; } = string.Empty;

        //FechaRegistro   datetime	8	no
        public DateTime FechaRegistro { get; set; }
    }
}
