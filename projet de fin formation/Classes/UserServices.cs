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
        public static User GetUserById(int idUser)
        {           
            using (SqlConnection Cnx = new SqlConnection(ADO.connectionString))
            {
                SqlCommand command = new SqlCommand("SELECT LoginUser,mot_de_passe,IdRole FROM compteUser WHERE code_User = @id;", Cnx);
                command.Parameters.Add(new SqlParameter("id",idUser));
                Cnx.Open();
                SqlDataReader reader = command.ExecuteReader();
                if (reader.HasRows)
                {
                    reader.Read();
                   return new User(idUser, reader.GetString(0), reader.GetString(1), reader.GetInt32(2));
                }
            }
            return new User();  
        }
        public static bool AddUser(string username, string password, int idRole)
        {
            using (SqlConnection Cnx = new SqlConnection(ADO.connectionString))
            {
                SqlCommand command = new SqlCommand("INSERT INTO compteUser VALUES(@login,@password,@idrole);", Cnx);
                command.Parameters.Add(new SqlParameter("login", username));
                command.Parameters.Add(new SqlParameter("password",UserServices.ComputePasswordHash(password)));
                command.Parameters.Add(new SqlParameter("idrole", idRole));
                Cnx.Open();
                return command.ExecuteNonQuery() >= 1;
            }            
        }
        public static bool DeleteUser(int idUser)
        {
            using (SqlConnection Cnx = new SqlConnection(ADO.connectionString))
            {
                SqlCommand command = new SqlCommand("DELETE FROM compteUser WHERE code_User = @idUser;", Cnx);
                command.Parameters.Add(new SqlParameter("idUser", idUser));
                Cnx.Open();
                return command.ExecuteNonQuery() >= 1;
            }
        }
        public static void UpdateUser(int idUser, string username, string password, int idRole)
        {
            using (SqlConnection Cnx = new SqlConnection(ADO.connectionString))
            {
                SqlCommand command = new SqlCommand("UPDATE compteUser SET LoginUser = @login,mot_de_passe = @password,IdRole = @idrole WHERE code_User = @idUser;", Cnx);
                command.Parameters.Add(new SqlParameter("idUser", idUser));
                command.Parameters.Add(new SqlParameter("login", username));
                command.Parameters.Add(new SqlParameter("password", UserServices.ComputePasswordHash(password)));
                command.Parameters.Add(new SqlParameter("idrole", idRole));
                Cnx.Open();
                command.ExecuteNonQuery();
            }


        }
    }
}
