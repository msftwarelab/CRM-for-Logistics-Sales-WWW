
namespace Application.Contact.Queries.Create
{
    public class CreateContactResponse
    {
        public CreateContactResponse(int globalContactId) 
        {
            GlobalContactId = globalContactId;
        }

        public int GlobalContactId { get; }
    }
}
