using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using Dapper;
using Microsoft.AspNetCore.Mvc;
using MySql.Data.MySqlClient;
namespace CoreLab.Models
{
    public class VehicleData
    {
        public VehicleData()
        {}
        public long IMEI { get; set; }

        public int ThingType { get; set; }

        public int TotalPlotsReviewed { get; set; }

        public float Missing { get; set; }

        public DateTime LastUpdateTime { get; set; }

        public string PayloadId { get; set; }

        public string FeedProvider { get; set; }

        public string LastMessagedReceived { get; set; }

        static readonly string connectionString = "Server=localhost; database={0}; UID=root; password=Michaelsantos1234; Database=sys";

        // This method returns back a list of information for each
        // Vehicle.
        public static List<VehicleData> GetVehicleData()
        {
            List<VehicleData> vechicleData = new List<VehicleData>();


            // using keyword here will close off the database connection after usage
            using (IDbConnection con = new MySqlConnection(connectionString))
            {
                // If the state of the connection is close, let's open a new one to connect
                if (con.State == ConnectionState.Closed)
                    con.Open();

                // Query() method maps the columsn within a row retrieved from the sql statement to the
                // declared properties up top. 
                vechicleData = con.Query<VehicleData>("SELECT * FROM PlotValidation;").ToList();


            }
            // returns a list of vehicle data
            return vechicleData;
        }
    }
}
