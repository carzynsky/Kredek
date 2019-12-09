using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArkadiuszCarzynskiLab3Zadanie
{
    class SignIn
    {
        // Configuration Manager potrzebuje, aby dodac do referencji biblioteki System.Config
        private readonly Func<SqlConnection> dbConnectionCarRental = () => new SqlConnection(ConfigurationManager.ConnectionStrings["CarRental"].ConnectionString);
       
        // odpowiednie propercje do zapytania sql, id pracownika i hasła
        public SqlCommand QuerySql { get; set; }
        public string WorkerId { get; set; }
        public string Password { get; set; }

        /// <summary>
        /// Konstruktor klasy SignIn
        /// </summary>
        /// <param name="WorkerId"></param>
        /// <param name="Password"></param>
        public SignIn(string WorkerId, string Password)
        {
            this.WorkerId = WorkerId;
            this.Password = Password;
        }

        /// <summary>
        /// Metoda sprawdzająca poprawność wpisanych danych (id pracownika i hasła)
        /// </summary>
        /// <returns></returns>
        public bool SignInCarRental()
        {
            int valueResult;
            bool isTrue = false;
            string query = "SELECT COUNT (Workers.WorkerId) from Workers where WorkerId = @WorkerId and Password = @Password";
            using (var connection = dbConnectionCarRental())
            {
                connection.Open();
                QuerySql = new SqlCommand(query, connection);
                QuerySql.Parameters.Add(new SqlParameter("@WorkerId", WorkerId));
                QuerySql.Parameters.Add(new SqlParameter("@Password", Password));
                valueResult = (int)QuerySql.ExecuteScalar();
                if (valueResult >= 1)
                {
                    isTrue = true;
                    return isTrue;
                }


            }
            return isTrue;
        }


    }
}
