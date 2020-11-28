using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace week67practice.Models
{

    //Defines what a season is and can use for the SeasonAPI controller as an object
    public class Season
    {
        //What describes a season?
        public string SeasonName;  //"public" allows access to te SeasonAPI controller > SeasonInfo.SeasonName = season;
        public string PhotographerName;
        public string ImageURL;
        public int TempCelcius;
    }
}