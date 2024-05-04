
namespace Application.Company.Queries.Delete
{
    public class DeleteCompanyResponse
    {
        public DeleteCompanyResponse(int globalCompanyId)
        {
            GlobalCompanyId = globalCompanyId;
        }

        public int GlobalCompanyId { get; set; }
    }
}
