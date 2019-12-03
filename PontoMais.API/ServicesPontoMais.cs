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

        #region Colaboradores

        public async Task<ApiResponse<object>> CriaColaborador(ColaboradorToSet colaborador)
        {
            var response = await _restService.Post<object>("employees", colaborador);

            return response;
        }

        public async Task<ApiResponse<object>> AtualizaColaborador(ColaboradorToSet colaborador, int employee_id)
        {
            var response = await _restService.Put<object>($"employees/{employee_id}", colaborador);

            return response;
        }

        public async Task<ApiResponse<object>> DemitirColaborador(int employee_id)
        {
            var response = await _restService.Put<object>($"employees/{employee_id}/dismiss", null);

            return response;
        }

        public async Task<ApiResponse<object>> VerificaStatusColaborador(int employee_id)
        {
            var response = await _restService.Get<object>($"employees/{employee_id}/status");

            return response;
        }

        #endregion

        #region Ferias

        public async Task<ApiResponse<object>> CriaFerias(FeriasToSet ferias, int employee_id)
        {
            var response = await _restService.Post<object>($"employees/{employee_id}/absences", ferias);

            return response;
        }

        public async Task<ApiResponse<string>> DeletaFerias(int employee_id, int absence_id)
        {
            var response = await _restService.Delete($"employees/{employee_id}/absences/{absence_id}");

            return response;
        }

        #endregion

        #region Relatorios

        public async Task<ApiResponse<object>> GetJornada(JornadaToGet jornada)
        {
            var response = await _restService.Post<object>($"reports/work_days", jornada);

            return response;
        }

        #endregion
    }
}
