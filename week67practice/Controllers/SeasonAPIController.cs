using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using week67practice.Models;
//using System.Web.Http.Cors; //step 2 : setting up cors (see step 1 in app_start > webcapiconfig
using Microsoft.AspNetCore.Cors;

namespace week67practice.Controllers
{
    public class SeasonAPIController : ApiController
    {
        /// <summary>
        /// Receives an input of the temperature and provides a message indicating the season   
        /// </summary>
        /// <param name="temperature">temperature input in degrees </param>
        ///  <example>GET api/SeasonAPI/Getseason/21 -> ["summer!", "Sean O.", "https://"]</example>
        ///  <example>GET api/SeasonAPI/Getseason/17 -> ["Fall!", "Jeremy Thomas", "https://"]</example>
        ///  <example>GET api/SeasonAPI/Getseason/-10 -> ["Winter", Bob Canning", "https://"]</example>
        /// <returns> season with the temperature</returns>


        [Route("api/SeasonAPI/GetSeason/{temperature}")]
        [EnableCors(origins: "*", methods: "*", headers: "*")] //step 3 of setting up CORS webapi
        public Season GetSeason(int? temperature)
        {
            Season SeasonInfo = new Season();
            string season="";
            string author = "";
            string img = "";

           

            if (temperature == null) 
            {
                season = "unknown";
                author = "unknown";
                img= "unknown";

                SeasonInfo.SeasonName = season;
                SeasonInfo.PhotographerName = author;
                SeasonInfo.ImageURL = img;
                SeasonInfo.TempCelcius = (int)temperature;

                return SeasonInfo;
            }

            if (temperature > 20)
            {
                season = "Summer";
                author = "Sean O";
                img = "https://unsplash.com/photos/KMn4VEeEPR8";
            }
            else if (temperature > 15 && temperature < 20)
            {

                season = "Fall";
                author = "Jeremy Thomas";
                img = "https://unsplash.com/photos/O6N9RV2rzX8";
            }
            else if (temperature > 10 && temperature < 15)
            {

                season = "Spring";
                author = "Sergey Shmidt";
                img = "https://unsplash.com/photos/koy6FlCCy5s";
            }
            else
            {
                season = "Winter";
                author = "Bob Canning";
                img = "https://unsplash.com/photos/r53rNKb_7s8";
            }

            
            SeasonInfo.SeasonName = season;
            SeasonInfo.PhotographerName = author;
            SeasonInfo.ImageURL = img;
            SeasonInfo.TempCelcius = (int)temperature;

            return SeasonInfo;

        }



    }
}
    

