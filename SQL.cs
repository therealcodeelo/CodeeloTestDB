using System.Data;
using System.Data.SqlClient;

namespace CodeeloTestDB
{
    internal class SQL
    {
        private const string CONNECTION_STRING = @"Data Source=(local)\SQLSRV;Initial Catalog=CodeeloTestDB;Integrated Security=true;";

        public static void ExecuteQuery(string query)
        {
            using (var connection = new SqlConnection(CONNECTION_STRING))
            {
                connection.Open();
                var command = new SqlCommand()
                {
                    Connection = connection,
                    CommandText = query
                };
                command.ExecuteNonQuery();
            }
        }
        public static int Authenticate(string login,string password)
        {
            using (var connection = new SqlConnection(CONNECTION_STRING))
            {
                connection.Open();
                var command = new SqlCommand()
                {
                    Connection = connection,
                    CommandText = $"SELECT [RoleID] FROM [CodeeloTestDB].[dbo].[User] where [Login] like '{login}' and [Password] like '{password}'"
                };
                var result = command.ExecuteScalar() ?? -1;
                var exist = int.TryParse(result.ToString(), out int roleID);
                if (exist)
                    return roleID;
                else
                    return -1;
            }
        }

        public static void GetDataForCombobox(string query, CodeeloUI.Controls.CodeeloComboBox combobox, string displayMember, string valueMember)
        {
            using (var connection = new SqlConnection(CONNECTION_STRING))
            {
                var dataTable = new DataTable();
                var sqlDataAdapter = new SqlDataAdapter(query, connection);
                sqlDataAdapter.Fill(dataTable);
                combobox.DataSource = dataTable;
                combobox.DisplayMember = displayMember;
                combobox.ValueMember = valueMember;
            }
        }
        public static void FillDgvByQuery(string query, DataGridView dgv)
        {
            using (var connection = new SqlConnection(CONNECTION_STRING))
            {
                var dataTable = new DataTable();
                var sqlDataAdapter = new SqlDataAdapter(query, connection);
                sqlDataAdapter.Fill(dataTable);
                
                dgv.DataSource = dataTable;
                dgv.AllowUserToAddRows = false;
                dgv.ReadOnly = true;
            }
        }
    }
}
