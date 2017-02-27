using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.SqlClient;

namespace CRUDUsingMVCwithAdoDotNet.Repository
{
    public class DB
    {
    public SqlConnection projectconnection;

        public   DB()
        {
            try
            {
                projectconnection = new SqlConnection(@"Data Source=.;Initial Catalog=StuData;Integrated Security=True");
            }
            catch(Exception ex)
            {
                throw new Exception("SqlConnection:" + ex.Message );
            }
        }
    }
}