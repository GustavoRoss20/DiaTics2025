namespace Domain.Dto
{
    public class ElementoDto<TValue>
    {
        public TValue Valor { get; set; } = default!;
        public string? Texto { get; set; }
        public string? Descripcion { get; set; }
    }
}
