using Application.Common;
using MediatR;

namespace Application.Contact.Queries.Delete
{
    public class DeleteContactQuery
        : IRequest<ApplicationResponse<DeleteContactResponse>>
    {
        public DeleteContactQuery() { }

        public DeleteContactQuery(DeleteContactRequest request) { 
            DeleteContactRequest = request; 
        }

        public DeleteContactRequest DeleteContactRequest { get; set; }  
    }
}
