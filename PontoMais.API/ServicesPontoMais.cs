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

        #region Unidades de Negocio

        public async Task<ApiResponse<BusinessUnits>> GetUnidades(int page = 1, int itemsPerPage = 10)
        {
            var response = await _restService.Post<BusinessUnits>($"business_units?page={page}&per_page={itemsPerPage}", null);

            return response;
        }

        #endregion

        #region Departamentos

        public async Task<ApiResponse<Departments>> GetDepartamentos(int page = 1, int itemsPerPage = 10)
        {
            var response = await _restService.Post<Departments>($"departments?&count=true&page={page}&per_page={itemsPerPage}", null);

            return response;
        }

        #endregion

        #region Equipes

        public async Task<ApiResponse<Teams>> GetEquipes(int page = 1, int itemsPerPage = 10)
        {
            var response = await _restService.Post<Teams>($"teams?&count=true&page={page}&per_page={itemsPerPage}", null);

            return response;
        }

        #endregion

        #region Cargos

        public async Task<ApiResponse<JobTitles>> GetCargos(int page = 1, int itemsPerPage = 10)
        {
            var response = await _restService.Post<JobTitles>($"job_titles?&count=true&page={page}&per_page={itemsPerPage}", null);

            return response;
        }

        #endregion

        #region Turnos

        public async Task<ApiResponse<Shifts>> GetTurnos(int page = 1, int itemsPerPage = 10)
        {
            var response = await _restService.Post<Shifts>($"shifts?&count=true&page={page}&per_page={itemsPerPage}", null);

            return response;
        }

        #endregion

        #region Colaboradores

        public async Task<ApiResponse<PontoMaisResponse>> CriaColaborador(ColaboradorToSet colaborador)
        {
            var response = await _restService.Post<PontoMaisResponse>("employees", colaborador);

            return response;
        }

        public async Task<ApiResponse<PontoMaisResponse>> AtualizaColaborador(ColaboradorToSet colaborador, int employee_id)
        {
            var response = await _restService.Put<PontoMaisResponse>($"employees/{employee_id}", colaborador);

            return response;
        }

        public async Task<ApiResponse<PontoMaisResponse>> DemitirColaborador(int employee_id)
        {
            var response = await _restService.Put<PontoMaisResponse>($"employees/{employee_id}/dismiss", null);

            return response;
        }

        public async Task<ApiResponse<PontoMaisResponse>> VerificaStatusColaborador(int employee_id)
        {
            var response = await _restService.Get<PontoMaisResponse>($"employees/{employee_id}/status");

            return response;
        }

        #endregion

        #region Ferias

        public async Task<ApiResponse<PontoMaisResponse>> CriaFerias(FeriasToSet ferias, int employee_id)
        {
            var response = await _restService.Post<PontoMaisResponse>($"employees/{employee_id}/absences", ferias);

            return response;
        }

        public async Task<ApiResponse<string>> DeletaFerias(int employee_id, int absence_id)
        {
            var response = await _restService.Delete($"employees/{employee_id}/absences/{absence_id}");

            return response;
        }

        #endregion

        #region Relatorios

        public async Task<ApiResponse<Reports>> GetJornadas(ReportsToGet jornada)
        {
            var response = await _restService.Post<Reports>($"reports/work_days", jornada);

            return response;
        }

        public async Task<ApiResponse<Reports>> GetRegistrosPontos(ReportsToGet registros)
        {
            var response = await _restService.Post<Reports>($"reports/time_cards", registros);

            return response;
        }

        #endregion
    }
}
