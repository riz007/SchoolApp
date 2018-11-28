using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

namespace StudentManagementApp.Models
{
    public class User
    {
        [Required]
        [Display(Name = "User Name")]
        public string userName { get; set; }

        [Required]
        [DataType(DataType.Password)]
        [Display(Name = "Password")]
        public string password { get; set; }

        [Display(Name = "Remember on this computer")]
        public bool RememberMe { get; set; }

        public bool IsValid(string _username, string _password)
        {
            string str = ConfigurationManager.ConnectionStrings["DefaultConnection"].ConnectionString;

            using (SqlConnection con = new SqlConnection())
            {
                con.ConnectionString = str;
                using (SqlCommand cmd = new SqlCommand(str))
                {
                    cmd.Connection = con;
                    cmd.CommandText = @"SELECT [userName] FROM [dbo].[Admin] " +
                       @"WHERE [userName] = @u AND [password] = @p";
                    cmd.Parameters
                      .Add(new SqlParameter("@u", SqlDbType.NVarChar))
                      .Value = _username;
                    cmd.Parameters
                        .Add(new SqlParameter("@p", SqlDbType.NVarChar))
                        .Value = _password;
                    con.Open();
                    using (SqlDataReader sdr = cmd.ExecuteReader())
                    {
                        if (sdr.HasRows)
                        {
                            sdr.Dispose();
                            cmd.Dispose();
                            return true;
                        }
                        else
                        {
                            sdr.Dispose();
                            cmd.Dispose();
                            return false;
                        }
                    }


                }


            }

        }

    }
}