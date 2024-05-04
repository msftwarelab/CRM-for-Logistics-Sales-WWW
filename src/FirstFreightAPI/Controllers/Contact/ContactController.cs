using Application.Common;
using Application.Common.Responses;
using Application.Contact.Queries.Create;
using Application.Contact.Queries.Delete;
using Application.Contact.Queries.Get;
using Application.Contact.Queries.List;
using Application.Contact.Queries.Update;
using FirstFreightAPI.Controllers.Base;
using MediatR;
using Microsoft.AspNetCore.Mvc;

namespace FirstFreightAPI.Controllers.Contact
{
    [Route("api/[controller]")]
    [ApiController]
    public class ContactController : ApiControllerBase
    {
        public ContactController()
        {
        }

        [HttpGet("Get/{globalContactId}/{subscriberId}")]
        [Produces("application/json")]
        [ProducesResponseType(typeof(ContactViewModel), StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        [ProducesResponseType(typeof(string), StatusCodes.Status500InternalServerError)]
        public async Task<IActionResult> GetContact(
            [FromRoute] int globalContactId,
            [FromRoute] int subscriberId,
            CancellationToken ct)
        {
            ApplicationResponse<ContactViewModel> response =
                await Mediator.Send(new GetContactQuery(globalContactId, subscriberId), ct);

            return GetResponse(response);
        }


        [ProducesResponseType(typeof(CreateContactResponse), StatusCodes.Status201Created)]
        [ProducesResponseType(typeof(ValidationFailureResponse), StatusCodes.Status400BadRequest)]
        [ProducesResponseType(typeof(string), StatusCodes.Status500InternalServerError)]
        [Produces("application/json")]
        [HttpPost("Add")]
        public async Task<IActionResult> AddContact(
            [FromBody] CreateContactRequest request,
            CancellationToken ct
        )
        {
            ApplicationResponse<CreateContactResponse> response =
                await Mediator.Send(new CreateContactQuery(request), ct);

            return GetResponse(response);
        }

        [ProducesResponseType(typeof(CreateContactResponse), StatusCodes.Status201Created)]
        [ProducesResponseType(typeof(ValidationFailureResponse), StatusCodes.Status400BadRequest)]
        [ProducesResponseType(typeof(string), StatusCodes.Status500InternalServerError)]
        [Produces("application/json")]
        [HttpPost("Update")]
        public async Task<IActionResult> UpdateContact(
            [FromBody] UpdateContactRequest request,
            CancellationToken ct
        )
        {
            ApplicationResponse<UpdateContactResponse> response =
                await Mediator.Send(new UpdateContactQuery(request), ct);

            return GetResponse(response);
        }

        [ProducesResponseType(typeof(CreateContactResponse), StatusCodes.Status201Created)]
        [ProducesResponseType(typeof(ValidationFailureResponse), StatusCodes.Status400BadRequest)]
        [ProducesResponseType(typeof(string), StatusCodes.Status500InternalServerError)]
        [Produces("application/json")]
        [HttpPost("Delete")]
        public async Task<IActionResult> DeleteContact(
            [FromBody] DeleteContactRequest request,
            CancellationToken ct
        )
        {
            ApplicationResponse<DeleteContactResponse> response =
                await Mediator.Send(new DeleteContactQuery(request), ct);

            return GetResponse(response);
        }


        [HttpGet("List/")]
        [Produces("application/json")]
        [ProducesResponseType(typeof(ContactViewModel), StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        [ProducesResponseType(typeof(string), StatusCodes.Status500InternalServerError)]
        public async Task<IActionResult> ListContact(
            [FromQuery(Name = "SubscriberId")] int? SubscriberId,
            [FromQuery(Name = "UserId")] int? UserId,
            [FromQuery(Name = "UserIdGlobal")] int? UserIdGlobal,
            [FromQuery(Name = "GlobalCompanyId")] int? GlobalCompanyId,
            [FromQuery(Name = "ContactTypeId")] int? ContactTypeId,
            [FromQuery(Name = "SortBy")] string? SortBy,
            [FromQuery(Name = "Keyword")] string? Keyword,
            [FromQuery(Name = "KeywordCity")] string? KeywordCity,
            [FromQuery(Name = "KeywordCountry")] string? KeywordCountry,
            [FromQuery(Name = "KeywordPostalCode")] string? KeywordPostalCode,
            CancellationToken ct)
        {
            ListContactQuery requet = new();
            if (SubscriberId != null)
                requet.SubscriberId = (int)SubscriberId;
            if (UserId != null)
                requet.UserId = (int)UserId;
            if (UserIdGlobal != null)
                requet.UserIdGlobal = (int)UserIdGlobal;
            if (GlobalCompanyId != null)
                requet.GlobalCompanyId = (int)GlobalCompanyId;
            if (ContactTypeId != null)
                requet.ContactTypeId = (int)ContactTypeId;
            if (SortBy != null)
                requet.SortBy = SortBy;
            else
                requet.SortBy = "";
            if (Keyword != null)
                requet.Keyword = Keyword;
            else
                requet.Keyword = "";
            if (KeywordCity != null)
                requet.KeywordCity = KeywordCity;
            else
                requet.KeywordCity = "";
            if (KeywordCountry != null)
                requet.KeywordCountry = KeywordCountry;
            else
                requet.KeywordCountry = "";
            if (KeywordPostalCode != null)
                requet.KeywordPostalCode = KeywordPostalCode;
            else
                requet.KeywordPostalCode = "";

            ApplicationResponse<ContactListViewModel> response =
                await Mediator.Send(requet, ct);

            return GetResponse(response);
        }
    }    
}
