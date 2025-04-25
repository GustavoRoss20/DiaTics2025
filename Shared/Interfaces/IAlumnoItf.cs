using Domain.Dto;
using Domain.Entities;

namespace Domain.Interfaces
{
    public interface IAlumnoItf
    {
        Task<AlumnoEtd> Obtener_Alumno_Detalle(string numeroControl);

        Task<ProcesoDto<bool>> Registrar_Alumno(AlumnoEtd alumno);
    }
}
