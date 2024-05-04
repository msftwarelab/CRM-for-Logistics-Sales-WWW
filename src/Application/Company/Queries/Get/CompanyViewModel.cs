using Application.Company.Common;

namespace Application.Company.Queries.Get
{
    public class CompanyViewModel
    {
        public CompanyViewModel() { }

        public CompanyViewModel(CompanyDto companyDto)
        {
            CompanyDto = companyDto;
        }   

        public CompanyDto CompanyDto { get; }
    }
}
