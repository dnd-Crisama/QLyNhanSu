using System.Data.SqlClient;
using System.Data;

namespace QLyNhanSu.BLL
{
    internal class Dataprovider
    {
        private String ConnectionSTR = "Data Source=NGUYENHOANGNAM\\SQLEXPRESS;Initial Catalog=\"19-4-2024 database\";Integrated Security=True";

        public DataTable ExecuteQuery(String query)
        {
            SqlConnection connection = new SqlConnection(ConnectionSTR);
            connection.Open();

            SqlCommand Command = new SqlCommand(query, connection);

            SqlDataAdapter adapter = new SqlDataAdapter(Command);

            DataTable data = new DataTable();
            adapter.Fill(data);

            connection.Close();
            return data;
        }
    }
}

