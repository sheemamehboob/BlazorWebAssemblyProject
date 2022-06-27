using BlazorWasmPilet.Shared;

namespace BlazorWasmPilet.Client.Services
{
    public interface IHealthCareProviderService
    {
        Task<IEnumerable<HealthCareProvider>> GetAllHealthCareProvidersAsync();
        Task<IEnumerable<HealthCareProvider>> Search(string name);

        Task<HealthCareProvider> GetHealthCareProvider(int healthCareProviderId);
        Task<HealthCareProvider> AddHealthCareProvider(HealthCareProvider healthCareProvider);

        Task<HealthCareProvider> UpdateHealthCareProvider(HealthCareProvider healthCareProvider);
        Task DeleteHealthCareProvider(int healthCareProviderId);
    }
}
