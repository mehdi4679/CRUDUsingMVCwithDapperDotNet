using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Dapper;
using CRUDUsingMVCwithAdoDotNet.Models;
using System.Data.SqlClient;

namespace CRUDUsingMVCwithAdoDotNet.Repository
{
    public class PersonRepository:DB
    {
        public int  AddPerson(Models.Person obj)
        {
            try
            {
                projectconnection.Open();
               int i= projectconnection.Execute("Prc_AddPerson", obj, commandType: System.Data.CommandType.StoredProcedure);
              return i;
            }
            catch
            {
                return 0;
            }
            finally
            {
                if (projectconnection.State == System.Data.ConnectionState.Open)
                {
                    projectconnection.Close();
                }
            }


        }


        public  List<Person> Getlist(Person obj)
        {
            //projectconnection.Open();
            //SqlCommand cmd = new SqlCommand("",projectconnection);
            //cmd.Parameters.Add(new SqlParameter("Fname", System.Data.SqlDbType.NVarChar)).Value=obj.FName;
            //cmd.Parameters.Add(new SqlParameter("LName", System.Data.SqlDbType.NVarChar)).Value = obj.LName;
            //cmd.Parameters.Add(new SqlParameter("FatherName", System.Data.SqlDbType.NVarChar)).Value = obj.FatherName;
            //cmd.Parameters.Add(new SqlParameter("PersonId", System.Data.SqlDbType.Int)).Value = obj.PersonId;
            //SqlDataAdapter da = new SqlDataAdapter(cmd, projectconnection);
            //projectconnection.Open();
            try
            {
                projectconnection.Open();
                List<Person> t = SqlMapper.Query<Person>(projectconnection, "Person_Getlist", obj).ToList();
                return t;
            }
            catch
            {
                return null;
            }
            finally
            {
                if(projectconnection.State==System.Data.ConnectionState.Open)
                projectconnection.Close();
            }  
 
        }

    }
}