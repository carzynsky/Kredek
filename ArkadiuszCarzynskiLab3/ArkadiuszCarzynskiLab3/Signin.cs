using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArkadiuszCarzynskiLab3
{
    class Signin
    {

        private readonly Func<SqlConnection> dbConnectionWareHouse = () => new SqlConnection(ConfigurationManager.ConnectionStrings["Warehouse"].ConnectionString);
        public SqlCommand QuerySql { get; set; }
        public string UserName { get; set; }
        public string Password { get; set; }
        
        /// <summary>
        /// Konstruktor klasy Signin
        /// </summary>
        /// <param name="userName"></param>
        /// <param name="password"></param>
        public Signin(string userName, string password)
        {
            UserName = userName;
            Password = password;
        }
        
        public bool SignInWareHouse()
        {
            int valueResult;
            bool isTrue = false;
            string query = "SELECT COUNT (UserLogin.UserName) from UserLogin where UserName = @Username and Password = @Password";
            using(var connection = dbConnectionWareHouse())
            {
                connection.Open();
                QuerySql = new SqlCommand(query, connection);
                QuerySql.Parameters.Add(new SqlParameter("@Username", UserName));
                QuerySql.Parameters.Add(new SqlParameter("@Password", Password));
                valueResult = (int)QuerySql.ExecuteScalar();
                if(valueResult >= 1)
                {
                    isTrue = true;
                    return isTrue;
                }


            }
            return isTrue;
        }
    }
}
