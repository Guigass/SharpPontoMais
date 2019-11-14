using PontoMais.API.GlobalServices;
using PontoMais.API.Models;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace PontoMais.API
{
    public class ServicesPontoMais : IDisposable
    {
        private RestService _restService;

        public ServicesPontoMais(string apiToken, string apiUrl = "https://api.pontomais.com.br/external_api/v1/")
        {
            if (String.IsNullOrEmpty(apiToken))
                throw new Exception("Voce precisa passar um token");

            _restService = new RestService(apiToken, apiUrl);
        }

        public void Dispose()
        {
            _restService.Dispose();
        }

        #region Unidades de Negócio

        public async Task<ApiResponse<List<BusinessUnit>>> GetUnidadesNegocio()
        {
            var response = await _restService.Get<List<BusinessUnit>>("business_units");

            return response;
        }

        #endregion
    }
}
