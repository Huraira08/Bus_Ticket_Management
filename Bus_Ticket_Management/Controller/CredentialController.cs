using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace Bus_Ticket_Management.Controller
{
    static class CredentialController
    {
        public static string[] GetCredentials()
        {
            SqlDataReader reader = Model.DatabaseConnection.GetCredentialReader();
            string[] cred = new string[2];
            while(reader.Read())
            {
                cred[0] = reader["ID"].ToString();
                cred[1] = reader["Password"].ToString();
                return cred;
            }
            return cred;
        }
    }
}
