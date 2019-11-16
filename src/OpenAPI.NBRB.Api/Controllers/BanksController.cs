using System.Collections.Generic;
using System.Net;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using OpenAPI.NBRB.Domain.Contracts;
using OpenAPI.NBRB.Domain.Contracts.ViewModels;
using Swashbuckle.AspNetCore.Annotations;

namespace OpenAPI.NBRB.Api.Controllers
{
    [ApiController]
    [Produces("application/json")]
    [Route("v1/[controller]")]
    public class BanksController : ControllerBase
    {
        private readonly IBankService _bankService;

        public BanksController(IBankService bankService)
        {
            _bankService = bankService;
        }

        [HttpGet]
        [SwaggerOperation(
            Summary = "Get list of Banks",
            OperationId = "GetBanksList",
            Tags = new[] { "Banks" })]
        [SwaggerResponse((int)HttpStatusCode.OK, Type = typeof(IEnumerable<BankViewModel>))]
        public async Task<IEnumerable<BankViewModel>> Get()
        {
            var result = await _bankService.GetBanksAsync();
            return result;
        }

        /// <summary>
        /// Get list of <cref>BanksViewModel</cref>
        /// </summary>


        /// <summary>Service for providing operations for <cref>BankViewModel</cref></summary>
        /// <returns>The list of <cref>BanksViewModel</cref>.</returns>


        //[SwaggerOperation]
        /// </summary>
        /// <remarks>
        /// Sample request:
        ///
        ///     GET /Banks
        ///     {
        ///        "id": 1,
        ///        "name": "Item1",
        ///        "isComplete": true
        ///     }
        ///
        /// </remarks>
    }
}
