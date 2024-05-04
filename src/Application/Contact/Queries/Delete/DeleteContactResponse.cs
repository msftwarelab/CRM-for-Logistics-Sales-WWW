
namespace Application.Contact.Queries.Delete
{
    public class DeleteContactResponse
    {
        public DeleteContactResponse(int globalContactId) 
        {
            GlobalContactId = globalContactId;
        }

        public int GlobalContactId { get; }
    }
}
