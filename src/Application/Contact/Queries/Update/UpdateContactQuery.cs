using Application.Common;
using MediatR;

namespace Application.Contact.Queries.Update
{
    public class UpdateContactQuery
        : IRequest<ApplicationResponse<UpdateContactResponse>>
    {
        public UpdateContactQuery() 
        { 
        
        }

        public UpdateContactQuery(UpdateContactRequest request)
        {
            UpdateContactRequest = request;
        }

        public UpdateContactRequest UpdateContactRequest { get; set; }
    }
}
