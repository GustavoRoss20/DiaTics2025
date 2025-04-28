using Domain.Dto;

namespace Domain.Interfaces
{
    public interface IGeneralItf
    {
        Task<List<ElementoDto<byte>>> Obtener_Lst_Elemento_Taller();
    }
}
