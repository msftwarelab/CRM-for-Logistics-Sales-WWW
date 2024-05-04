using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Company.Queries.Update
{
    public class UpdateCompanyResponse
    {
        public UpdateCompanyResponse(int globalCompanyId)
        {
            GlobalCompanyId = globalCompanyId;
        }

        public int GlobalCompanyId { get; set; }
    }
}
