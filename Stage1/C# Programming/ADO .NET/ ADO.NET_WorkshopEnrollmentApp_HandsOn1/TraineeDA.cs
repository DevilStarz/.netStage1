using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
using System.Configuration;

namespace WorkShopEnrollmentApp
{
      public class TraineeDA
    {
        

        public bool AddTraineeDetails(TraineeBO objBO)
        {
            try
            {
                SqlConnection con = new SqlConnection(ConnectionString);
                con.Open();
                string query = "insert into tblTrainee values(" + objBO.TraineeId + ",'" + objBO.TraineeName + "','" + objBO.BatchCode + "')";
                SqlCommand cmd = new SqlCommand(query, con);
                int i = cmd.ExecuteNonQuery();
                if (i > 0)
                    return true;
                else
                    return false;
            }
            catch (Exception ex)
            {
                return false;
            }
        }
        public string ConnectionString
        {
            get
            {
                return ConfigurationManager.ConnectionStrings["SqlCon"].ConnectionString;
            }
        }
    }
}
