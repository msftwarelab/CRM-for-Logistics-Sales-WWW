using Application.Common;
using MediatR;

namespace Application.Contact.Queries.Create
{
    public class CreateContactQuery
        : IRequest<ApplicationResponse<CreateContactResponse>>
    {
        public CreateContactQuery() 
        { 
        
        }

        public CreateContactQuery(CreateContactRequest request) {
            CreateContactRequest = request;
        }

        public CreateContactRequest CreateContactRequest {  get; set; }
    }
}
