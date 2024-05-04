using FirstFreightAPI.Entities.Shared;

namespace Application.Company.Queries.List
{
    public class CompanyListViewModel
    {
        public CompanyListViewModel()
        {
            Companies = new();
            AccessibleCompanyIds = new();
        }

        public List<GlobalCompany> Companies { get; }
        public int TotalPages { get; set; }
        public int Records { get; set; }
        public List<int> AccessibleCompanyIds { get; }
    }
}
