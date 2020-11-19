using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EventsDota
{
     class Events
    {

        public Events()
        {
            Value = "";
            Name = "";
            StartDate = "";
            EndDate = "";
            Country = "";
            City = "";
            PrizePool = "";
            DpcPoints = "";
            Winner = "";
            RunnerUp = "";
            NumberOfTeams = "";
        }
        public string Value { get; set; }
        public string Name { get; set; }
        public string StartDate { get; set; }
        public string EndDate { get; set; }
        public string Country { get; set; }
        public string City { get; set; }
        public string PrizePool { get; set; }
        public string DpcPoints { get; set; }
        public string Winner { get; set; }
        public string RunnerUp { get; set; }
        public string NumberOfTeams { get; set; }
    }
        //public Events(string[] data)
        //{
        //    value = data[0];
        //    name = data[1];
        //    startDate = data[2];
        //    endDate = data[3];
        //    country = data[4];
        //    city = data[5];
        //    prizePool = data[6];
        //    dpcPoints = data[7];
        //    winner = data[8];
        //    runnerUp = data[9];
        //    numberOfTeams = data[10];
        //}
        //public bool Compare(Events obj)
        //{
        //    if ((this.value == obj.value) &&
        //        (this.name == obj.name) &&
        //        (this.startDate == obj.startDate) &&
        //        (this.endDate == obj.endDate) &&
        //        (this.country == obj.country) &&
        //        (this.city == obj.city) &&
        //        (this.prizePool == obj.prizePool) &&
        //        (this.dpcPoints == obj.dpcPoints) &&
        //        (this.winner == obj.winner) &&
        //        (this.runnerUp == obj.runnerUp) &&
        //        (this.numberOfTeams == obj.numberOfTeams))
        //    {
        //        return true;
        //    }
        //    else
        //    {
        //        return false;
        //    }
        //}
    //}
}