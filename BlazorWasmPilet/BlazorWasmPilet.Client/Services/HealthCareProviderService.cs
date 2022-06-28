using BlazorWasmPilet.Shared;
using System.Net.Http.Json;

namespace BlazorWasmPilet.Client.Services
{
    public class HealthCareProviderService : IHealthCareProviderService
    {
        private readonly HttpClient httpClient;

        public HealthCareProviderService(HttpClient httpClient)
        {
            this.httpClient = httpClient;

        }

        public Task<HealthCareProvider> AddHealthCareProvider(HealthCareProvider healthCareProvider)
        {
            throw new NotImplementedException();
        }

        public Task DeleteHealthCareProvider(int healthCareProviderId)
        {
            throw new NotImplementedException();
        }

        public async Task<IEnumerable<HealthCareProvider>> GetAllHealthCareProvidersAsync()
        {
            return await httpClient.GetFromJsonAsync<IEnumerable<HealthCareProvider>>("/api/healthcareprovider");
        }

        public Task<HealthCareProvider> GetHealthCareProvider(int healthCareProviderId)
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<HealthCareProvider>> Search(string name)
        {
            throw new NotImplementedException();
        }

        public Task<HealthCareProvider> UpdateHealthCareProvider(HealthCareProvider healthCareProvider)
        {
            throw new NotImplementedException();
        }
    }
}
