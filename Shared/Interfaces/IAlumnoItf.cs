using Domain.Dto;
using Domain.Entities;

namespace Domain.Interfaces
{
    public interface IAlumnoItf
    {
        string Ejemplo();

        Task<AlumnoEtd> Obtener_Alumno_Detalle(string numeroControl);

        Task<ProcesoDto<bool>> Crear_CatUsuarioSistema(AlumnoEtd alumno);
    }
}
