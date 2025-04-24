namespace Domain.Dto
{
    public class ProcesoDto<T>
    {
        public T Resultado { get; set; } = default!;

        public string Mensaje { get; set; } = null!;
    }
}
