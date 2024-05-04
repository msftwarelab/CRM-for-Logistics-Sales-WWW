
namespace Application.Contact.Queries.Update
{
    public class UpdateContactResponse
    {
        public UpdateContactResponse(int globalContactId)
        {
            GlobalContactId = globalContactId;
        }

        public int GlobalContactId { get; }
    }
}
