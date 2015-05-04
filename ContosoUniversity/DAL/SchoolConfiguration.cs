using System.Data.Entity;
using System.Data.Entity.SqlServer;

namespace ContosoUniversity.DAL
{
    public class SchoolConfiguration :DbConfiguration
    {
        public SchoolConfiguration()
        {
            SetExecutionStrategy("System.DataSqlClient", () => new SqlAzureExecutionStrategy());
        }
    }
}