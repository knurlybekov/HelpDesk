using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using Domain;

namespace Session
{
    public class Class2
    {
        SqlConnection conn;
        SqlConnectionStringBuilder connectionStringBuilder;
        void ConnectTo()
        {
            connectionStringBuilder = new SqlConnectionStringBuilder();
            connectionStringBuilder.DataSource = "DESKTOP-7VHVK81";
            connectionStringBuilder.InitialCatalog = "cnpcaqt";
            connectionStringBuilder.IntegratedSecurity = true;
            conn = new SqlConnection(connectionStringBuilder.ToString());
        }

       // public void Insert(Class1 p)
        //{
        //  try
          //  {
            //    string cmdText = "INSERT INTO dbo.prob(vidprob, nomprint, nazvprint, opisasnie) VALUES(@vidprob, @nomprint, @nazvprint, @opisasnie)";
              //  SqlCommand cmd = new SqlCommand(cmdText, conn);
                //cmd.Parameters.AddWithValue("@vidprob", p.Vidprob);
             //   cmd.Parameters.AddWithValue("@opisasnie", p.Opisasnie);
               // conn.Open();
            //    cmd.ExecuteNonQuery();
           // }
            //catch (Exception)
            //{
              //  ;
            //}
        }
    }
//} 

