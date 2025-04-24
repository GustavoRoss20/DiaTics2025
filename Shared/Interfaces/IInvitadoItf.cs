using Domain.Dto;
using Domain.Entities;

namespace Domain.Interfaces
{
    public interface IInvitadoItf
    {
        Task<ProcesoDto<bool>> Registrar_Invitado(InvitadoEtd invitado);
    }
}
