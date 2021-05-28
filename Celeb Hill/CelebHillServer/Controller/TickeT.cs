using Celeb_Hill.Model;
using CelebHillServer.Prefs;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Threading.Tasks;

namespace CelebHillServer.Controller
{
    [Route("api/[controller]/[action]")]
    [ApiController]
    public class TickeTController : ControllerBase
    {
        [HttpGet]
        public string GetList()
        {
            Database db = new Database();

            List<Concert> concs = new List<Concert>();

            SqlConnection conn = new SqlConnection(db.connectionString);
            conn.Open();

            SqlCommand command = new SqlCommand("SELECT * FROM [CelebHill].[dbo].[AddTickeT]", conn);

            using (SqlDataReader reader = command.ExecuteReader())
            {
                while (reader.Read())
                {
                    Concert conc = new Concert ((int)reader["id"], (string)reader["advtext"],
                                                        (string)reader["phonenumber"], 
                                                        Convert.ToSingle(reader["priceusd"]),
                                                        Convert.ToSingle(reader["course"]), Convert.ToSingle(reader["pricebyn"]));

                    concs.Add(conc);

                }
            }


            conn.Close();

            string output = JsonConvert.SerializeObject(concs, Formatting.None);

            HttpContext.Response.Headers.Add("Access-Control-Allow-Origin", "*");

            return output;




        }

        [HttpPost]
        public StatusCodeResult AddTickeT([FromForm] Concert concert)
        {
            Database db = new Database();
            SqlConnection conn = new SqlConnection(db.connectionString);
            conn.Open();

            String sqlQuery = $@"INSERT INTO [CelebHill].[dbo].[AddTicket]
           ([id]
           ,[advtext]
           ,[phonenumber]
           ,[priceusd]
           ,[course]
           ,[pricebyn])
     VALUES
           ({concert.id}
           ,'{concert.concert}'
           ,'{concert.phoneNumber}'
           ,{concert.priceUSD.ToString().Replace(",", ".")}
           ,{concert.courseOfUSD.ToString().Replace(",", ".")}
           ,{concert.priceBYN.ToString().Replace(",", ".")})";

            SqlCommand command = new SqlCommand(sqlQuery, conn);
            try
            {
                command.ExecuteNonQuery();
                return StatusCode(200);

            }
            catch
            {
                return StatusCode(500);
            }
            finally
            {
                conn.Close();
            }
        }
        


    }
}
