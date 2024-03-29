﻿using BlazorWasmPilet.Server.Models;
using Microsoft.AspNetCore.Mvc;
namespace BlazorWasmPilet.Server.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProvidersController: ControllerBase
    {
        private readonly IHealthCareProviderRepository healthCareProviderRepository;

        public ProvidersController(IHealthCareProviderRepository healthCareProviderRepository)
        {
            this.healthCareProviderRepository = healthCareProviderRepository;
        }

        [HttpGet]
        public async Task<IActionResult> GetHealthCareProviders()
        {
            try
            {
                return Ok(await this.healthCareProviderRepository.GetAllHealthCareProvidersAsync());
            }
            catch (Exception)
            {

                return StatusCode(StatusCodes.Status500InternalServerError, "Error retrieving the Health Care Providers");
            }
            
        }
    }
}
