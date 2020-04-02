using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using CoreLab.Models;
namespace CoreLab.Controllers
{
    public class HomeController : Controller
    {
        // Handles requests based on root directory - > /Home
        // Created an endpoint which retrieves all the data in the DB Table
        // by calling the method GetVehicleData() which returns a list of
        // vehicle data that was retrieved in the database.
        public List<VehicleData> IMEI()
        {
            foreach (var item in VehicleData.GetVehicleData())
            {
                Console.WriteLine(item);
            }
            return VehicleData.GetVehicleData();
        }
    }
}
