using System.Data;

namespace Application.Common.Interfaces
{
    public interface IDapperContext
    {
        IDbConnection CreateConnection();
    }
}
