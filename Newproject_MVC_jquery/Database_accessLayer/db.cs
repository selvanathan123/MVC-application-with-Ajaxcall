using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;

namespace Newproject_MVC_jquery.Database_accessLayer
{
    public class db
    {
        SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["con"].ConnectionString);

        public DataSet GetName(string prefix)
        {
            SqlCommand com = new SqlCommand("select * from Studenttabl where Name like '%'+@prefix+'%'", con);
            com.Parameters.AddWithValue(prefix, "@prefix");
            DataSet ds = new DataSet();
            SqlDataAdapter da = new SqlDataAdapter(com);
            da.Fill(ds);
            return ds;



        }
    }
}