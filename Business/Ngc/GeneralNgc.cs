using Data;
using Domain.Dto;
using Domain.Entities;
using Domain.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace Business.Ngc
{
    public class GeneralNgc : IGeneralItf
    {
        #region IOC

        private readonly IEfRepository _efRpstry;

        public GeneralNgc(IEfRepository efRpstry)
        {
            _efRpstry = efRpstry;
        }

        #endregion

        public async Task<List<ElementoDto<byte>>> Obtener_Lst_Elemento_Taller()
        {
            var query = from t in _efRpstry.Queryanle<TallerEtd>()
                        orderby t.Nombre
                        select new ElementoDto<byte>
                        {
                            Valor = t.Id,
                            Texto = t.Nombre.ToUpper()
                        };

            var result = await query.ToListAsync();
            return result;
        }
    }
}
