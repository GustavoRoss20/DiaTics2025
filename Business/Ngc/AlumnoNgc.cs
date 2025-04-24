using Domain.Dto;
using Domain.Entities;
using Domain.Interfaces;

namespace Business.Ngc
{
    public class AlumnoNgc : IAlumnoItf
    {

        public Task<ProcesoDto<bool>> Crear_CatUsuarioSistema(AlumnoEtd alumno)
        {
            throw new NotImplementedException();
        }

        public string Ejemplo()
        {
            return "hOLA";
        }

        public Task<AlumnoEtd> Obtener_Alumno_Detalle(string numeroControl)
        {
            throw new NotImplementedException();
        }
    }
}
