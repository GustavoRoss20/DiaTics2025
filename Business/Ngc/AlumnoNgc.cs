using Data;
using Domain.Dto;
using Domain.Entities;
using Domain.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace Business.Ngc
{
    public class AlumnoNgc : IAlumnoItf
    {
        #region IOC

        private readonly IEfRepository _efRpstry;

        public AlumnoNgc(IEfRepository efRpstry)
        {
            _efRpstry = efRpstry;
        }

        #endregion

        public async Task<AlumnoEtd> Obtener_Alumno_Detalle(string numeroControl)
        {
            var alumno_Qry = from a in _efRpstry.Queryanle<AlumnoEtd>()
                             where a.NumeroControl == numeroControl
                             select new AlumnoEtd
                             {
                                 NumeroControl = a.NumeroControl,
                                 Nombre = a.Nombre,
                                 ApellidoPaterno = a.ApellidoPaterno,
                                 ApellidoMaterno = a.ApellidoMaterno,
                                 Carrera = a.Carrera,
                                 RegistradoParaEvento = a.RegistradoParaEvento,
                                 FechaRegistro = a.FechaRegistro
                             };

            var result = await alumno_Qry.SingleOrDefaultAsync();
            return result;
        }

        public async Task<ProcesoDto<bool>> Registrar_Alumno(AlumnoEtd alumno)
        {
            var proceso = new ProcesoDto<bool>();

            try
            {
                // Buscar si el alumno existe
                var alumno_Etd = _efRpstry.Find<AlumnoEtd, string>(alumno.NumeroControl);

                if (alumno_Etd is null)
                {
                    proceso.Resultado = false;
                    proceso.Mensaje = "El alumno no existe en el sistema.";
                    return proceso;
                }

                _efRpstry.BeginTransaction();

                #region Registra el alumno al evento

                alumno_Etd.RegistradoParaEvento = true;
                alumno_Etd.FechaRegistro = DateTime.Now;

                _efRpstry.Update(alumno_Etd);
                await _efRpstry.SaveChangesAsync();

                #endregion

                await _efRpstry.CommitAsync()!;

                proceso.Resultado = true;
                proceso.Mensaje = "Se ha registrado el alumno para el evento.";
            }
            catch
            {
                await _efRpstry.RollbackAsync()!;
                proceso.Resultado = false;
                proceso.Mensaje = "Ocurrió un error al registrar el alumno al evento.";

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
