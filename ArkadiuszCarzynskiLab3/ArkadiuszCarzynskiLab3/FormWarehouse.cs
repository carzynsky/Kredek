using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ArkadiuszCarzynskiLab3
{
    public partial class FormWarehouse : Form
    {
        /// <summary>
        /// Configuration Manager potrzebuje, aby dodac do referencji biblioteki System.Config
        /// </summary>
        private readonly Func<SqlConnection> dbConnectionWareHouse = () => new SqlConnection(ConfigurationManager.ConnectionStrings["Warehouse"].ConnectionString);
        public FormWarehouse()
        {
            InitializeComponent();
            GetDataFromTable();
        }

        /// <summary>
        /// Metoda połączy dane z dataGridView
        /// </summary>
        public void GetDataFromTable()
        {
            using(var connection = dbConnectionWareHouse())
            {
                // Połączenia
                connection.Open();
                using(SqlDataAdapter adapter = new SqlDataAdapter("select * from UserLogin ", connection))
                {
                    // Wynik zapytania do tabeli
                    DataTable table = new DataTable();
                    adapter.Fill(table);
                    dataGridViewWarehouse.DataSource = table;
                }
            }
        }

        private void buttonFiltr_Click(object sender, EventArgs e)
        {
            using (var connection = dbConnectionWareHouse())
            {
                // Połączenia
                connection.Open();
                using (SqlDataAdapter adapter = new SqlDataAdapter("select * from UserLogin where UserName = 'Adam' ", connection))
                {
                    // Wynik zapytania do tabeli
                    DataTable table = new DataTable();
                    adapter.Fill(table);
                    dataGridViewWarehouse.DataSource = table;
                }
            }

        }
    }
}
