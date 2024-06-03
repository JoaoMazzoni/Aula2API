using Microsoft.Data.SqlClient;
using ModelsClassLibrary;

namespace Repositories
{
    public class InsuranceRepository
    {

        string strConn = "Server=127.0.0.1; Database=DBCar; User Id=sa; Password=SqlServer2019!; TrustServerCertificate=True";
        SqlConnection conn;

        public InsuranceRepository()
        {
            conn = new SqlConnection(strConn);
            conn.Open();
        }

        public int Insert(Insurance insurance)
        {
            int result = 0;

            try
            {
                SqlCommand cmd = new SqlCommand(Insurance.INSERT, conn);
                cmd.Parameters.Add(new SqlParameter("@Description", insurance.Description));
                result = (int)cmd.ExecuteScalar();

            }
            catch (Exception)
            {
                throw;
                result = 0;
            }
            finally
            {
                conn.Close();
            }
            return result;
        }

    }
}
