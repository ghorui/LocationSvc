using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace LocationSvc.Controllers
{
    public class LocationController : ApiController
    {
        //https://localhost:44373/api/location?cityName=dc
        public Models.Location GetLocation(string cityName)
        {
            return new Models.Location() { latitude = 10, lognitude = 20 };
        }
    }
}
