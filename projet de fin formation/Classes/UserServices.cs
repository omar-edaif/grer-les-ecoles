using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace projet_de_fin_formation

{
   public static class UserServices
    {
        public static List<string> GetPermissionsForRole(int idRole)
        {
            var listpermission = new List<string>();
            using (SqlConnection Cnx = new SqlConnection(ADO.connectionString))
            {
                SqlCommand command = new SqlCommand("SELECT	p.Name FROM RolePermission AS rp JOIN Permission AS p ON rp.IdPermission = p.Id WHERE rp.IdRole = @idRole;", Cnx);
                command.Parameters.Add(new SqlParameter("idRole", idRole));
                Cnx.Open();
                using (SqlDataReader reader = command.ExecuteReader())
                {
                    if (reader.HasRows)
                    {
                        while (reader.Read())
                        {
                            listpermission.Add(reader.GetString(0));
                        }                         
                    }
                }
            }
            return listpermission;
        }
        public static string ComputePasswordHash(string Password)
        {  
            using (SHA256 sha256Hash = SHA256.Create())
            {
                var bytes = sha256Hash.ComputeHash(Encoding.UTF8.GetBytes(Password));                
                return Convert.ToBase64String(bytes);
            }
        }
        public static List<Role> GetAllRoles()
        {
            var Roles = new List<Role>();
            try
            {
                using (SqlConnection Cnx = new SqlConnection(ADO.connectionString))
                {
                    SqlCommand command = new SqlCommand("SELECT Id , Name FROM dbo.Role;", Cnx);
                    Cnx.Open();
                    SqlDataReader reader = command.ExecuteReader();
                    if (reader.HasRows)
                    {
                        while (reader.Read())
                        {
                            Roles.Add(new Role(reader.GetInt32(0), reader.GetString(1), GetPermissionsForRole(reader.GetInt32(0))));
                        }
                    }
                }
                return Roles;
            }
            catch (Exception)
            {
                throw;              
            }
        }


    }
}
