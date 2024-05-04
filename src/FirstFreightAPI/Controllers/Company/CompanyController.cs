using Application.Common.Responses;
using Application.Common;
using Application.Contact.Queries.Create;
using FirstFreightAPI.Controllers.Base;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Application.Company.Queries.Create;
using Application.Company.Queries.Update;
using Application.Contact.Queries.Delete;
using Application.Company.Queries.Delete;
using Application.Contact.Queries.Get;
using Application.Contact.Queries.List;
using Application.Company.Queries.List;
using Application.Company.Queries.Get;

namespace FirstFreightAPI.Controllers.Company
{
    [Route("api/[controller]")]
    [ApiController]
    public class CompanyController : ApiControllerBase
    {
        public CompanyController() { }


        [ProducesResponseType(typeof(CreateContactResponse), StatusCodes.Status201Created)]
        [ProducesResponseType(typeof(ValidationFailureResponse), StatusCodes.Status400BadRequest)]
        [ProducesResponseType(typeof(string), StatusCodes.Status500InternalServerError)]
        [Produces("application/json")]
        [HttpPost("Add")]
        public async Task<IActionResult> AddCompany(
            [FromBody] CreateCompanyRequest request,
            CancellationToken ct
        )
        {
            ApplicationResponse<CreateCompanyResponse> response =
                await Mediator.Send(new CreateCompanyQuery(request), ct);

            return GetResponse(response);
        }

        [ProducesResponseType(typeof(CreateContactResponse), StatusCodes.Status201Created)]
        [ProducesResponseType(typeof(ValidationFailureResponse), StatusCodes.Status400BadRequest)]
        [ProducesResponseType(typeof(string), StatusCodes.Status500InternalServerError)]
        [Produces("application/json")]
        [HttpPost("Update")]
        public async Task<IActionResult> UpdateCompany(
            UpdateCompanyRequest request,
            CancellationToken ct
        )
        {
            ApplicationResponse<UpdateCompanyResponse> response =
                await Mediator.Send(new UpdateCompanyQuery(request), ct);

            return GetResponse(response);
        }

        [ProducesResponseType(typeof(CreateContactResponse), StatusCodes.Status201Created)]
        [ProducesResponseType(typeof(ValidationFailureResponse), StatusCodes.Status400BadRequest)]
        [ProducesResponseType(typeof(string), StatusCodes.Status500InternalServerError)]
        [Produces("application/json")]
        [HttpPost("Delete")]
        public async Task<IActionResult> DeleteCompany(
            [FromBody] DeleteCompanyRequest request,
            CancellationToken ct
        )
        {
            ApplicationResponse<DeleteCompanyResponse> response =
                await Mediator.Send(new DeleteCompanyQuery(request), ct);

            return GetResponse(response);
        }

        [HttpGet("Get/{globalCompanyId}/{subscriberId}")]
        [Produces("application/json")]
        [ProducesResponseType(typeof(ContactViewModel), StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        [ProducesResponseType(typeof(string), StatusCodes.Status500InternalServerError)]
        public async Task<IActionResult> GetCompany(
            [FromRoute] int globalCompanyId,
            [FromRoute] int subscriberId,
            CancellationToken ct)
        {
            ApplicationResponse<CompanyViewModel> response =
                await Mediator.Send(new GetCompanyQuery(globalCompanyId, subscriberId), ct);

            return GetResponse(response);
        }

        [HttpGet("List/")]
        [Produces("application/json")]
        [ProducesResponseType(typeof(ContactViewModel), StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        [ProducesResponseType(typeof(string), StatusCodes.Status500InternalServerError)]
        public async Task<IActionResult> ListCompany(
            [FromQuery(Name = "SubscriberId")] int SubscriberId,
            [FromQuery(Name = "UserId")] int? UserId,
            [FromQuery(Name = "UserIdGlobal")] int? UserIdGlobal,
            [FromQuery(Name = "FilterType")] string? FilterType,
            [FromQuery(Name = "RecordsPerPage")] int? RecordsPerPage,
            [FromQuery(Name = "CurrentPage")] int? CurrentPage,
            [FromQuery(Name = "Keyword")] string? Keyword,
            [FromQuery(Name = "CompanyType")] string? CompanyType,
            [FromQuery(Name = "SortBy")] string? SortBy,
            [FromQuery(Name = "LocationId")] int? LocationId,
            [FromQuery(Name = "CountryCode")] string? CountryCode,
            [FromQuery(Name = "SalesRep")] int? SalesRep,
            [FromQuery(Name = "PostalCode")] string? PostalCode,
            [FromQuery(Name = "City")] string? City,
            [FromQuery(Name = "CountryName")] string? CountryName,
            [FromQuery(Name = "IsCustomer")] bool? IsCustomer,
            CancellationToken ct)
        {
            ListCompanyQuery requet = new()
            {
                SubscriberId = SubscriberId
            };
                
            if (UserId != null)
                requet.UserId = (int)UserId;
            if (UserIdGlobal != null)
                requet.UserIdGlobal = (int)UserIdGlobal;
            if (FilterType != null)
                requet.FilterType = FilterType;
            if (RecordsPerPage != null)
                requet.RecordsPerPage = (int)RecordsPerPage;
            if (SortBy != null)
                requet.SortBy = SortBy;
            else
                requet.SortBy = "";
            if (Keyword != null)
                requet.Keyword = Keyword;
            else
                requet.Keyword = "";
            if (CurrentPage != null)
                requet.CurrentPage = (int)CurrentPage;

            if (Keyword != null)
                requet.Keyword = Keyword;
            else
                requet.Keyword = "";
            if (CompanyType != null)
                requet.CompanyType = CompanyType;
            else
                requet.CompanyType = "";
            if (LocationId != null)
                requet.LocationId = (int)LocationId;
            if (CountryCode != null)
                requet.CountryCode = CountryCode;
            else
                requet.CountryCode = "";
            if (SalesRep != null)
                requet.SalesRep = (int)SalesRep;
            if (PostalCode != null)
                requet.PostalCode = PostalCode;
            else
                requet.PostalCode = "";
            if (City != null)
                requet.City = City;
            else
                requet.City = "";
            if (CountryName != null)
                requet.CountryName = CountryName;
            else
                requet.CountryName = "";
            if (IsCustomer != null)
                requet.IsCustomer = (bool)IsCustomer;

            ApplicationResponse<CompanyListViewModel> response =
                await Mediator.Send(requet, ct);

            return GetResponse(response);
        }
    }
}
