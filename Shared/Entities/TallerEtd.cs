namespace Domain.Entities
{
    public class TallerEtd
    {
        //Id tinyint	1	no
        public byte Id { get; set; }

        //Nombre  varchar	100	no
        public string Nombre { get; set; } = string.Empty;

        public virtual List<InvitadoEtd>? LstInvitado { get; set; }
    }
}
