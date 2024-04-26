using System.Data.SqlClient;
using System.Data;

namespace QLyNhanSu.BLL
{
    internal class Dataprovider
    {
        private static Dataprovider instance;
        public static Dataprovider Instance
        {
            get { if (instance == null) instance = new Dataprovider(); return Dataprovider.instance; }
            private set { Dataprovider.instance = value; }
        }
        private Dataprovider() { }

        private String ConnectionSTR = "Data Source=NGUYENHOANGNAM\\SQLEXPRESS;Initial Catalog=\"25-4-2024 database\";Integrated Security=True";

        public DataTable ExecuteQuery(String query)
        {
            DataTable data = new DataTable();
            using (SqlConnection connection = new SqlConnection(ConnectionSTR))
            {
                connection.Open();

                SqlCommand Command = new SqlCommand(query, connection);

                SqlDataAdapter adapter = new SqlDataAdapter(Command);

               
                adapter.Fill(data);

                connection.Close();
            }
            return data;
        }
    }
}

