using Data;
using Domain.Dto;
using Domain.Entities;
using Domain.Interfaces;


namespace Business.Ngc
{
    public class InvitadoNgc : IInvitadoItf
    {
        #region IOC

        private readonly IEfRepository _efRpstry;

        public InvitadoNgc(IEfRepository efRpstry)
        {
            _efRpstry = efRpstry;
        }

        #endregion

        public async Task<ProcesoDto<bool>> Registrar_Invitado(InvitadoEtd invitado)
        {
            var proceso = new ProcesoDto<bool>();
            proceso.Resultado = true;

            try
            {
                _efRpstry.BeginTransaction();

                #region AGREGAR Invitado

                invitado.FechaRegistro = DateTime.Now;

                _efRpstry.Add(invitado);

                await _efRpstry.SaveChangesAsync();

                #endregion

                await _efRpstry.CommitAsync()!;

                proceso.Resultado = true;
                proceso.Mensaje = "Se ha registrado el invitado para el evento";
            }
            catch
            {
                await _efRpstry.RollbackAsync()!;
                proceso.Resultado = false;
                proceso.Mensaje = "Ocurrió un error al registrar el invitado al evento.";
                throw;
            }
            finally
            {
                _efRpstry.CloseTransaction();
            }

            return proceso;
        }
    }
}
