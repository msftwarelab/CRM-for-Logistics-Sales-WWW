
namespace Application.Company.Queries.Create
{
    public class CreateCompanyResponse
    {
        public CreateCompanyResponse(int globalCompanyId)
        {
            GlobalCompanyId = globalCompanyId;
        }

        public int GlobalCompanyId { get; set; }
    }
}
