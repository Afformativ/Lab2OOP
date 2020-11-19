using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace EventsDota
{
     class LinqToXML:IStrategy
    {
        
        public List<Events> AnalyzeFile(Events events)
        {
            List<Events> find = new List<Events>();
            var doc = XDocument.Load(@"D:\Proga\EventsDota\EventsDota\bin\Debug\EventsDataBase.xml");
            var res = from mySearch in doc.Descendants("Event")
                      where ((mySearch.Attribute("VALUE").Value.Equals(events.Value) || events.Value.Equals(String.Empty)) &&
                      (mySearch.Attribute("NAME").Value.Equals(events.Name) || events.Name.Equals(String.Empty)) &&
                      (mySearch.Attribute("START").Value.Equals(events.StartDate) || events.StartDate.Equals(String.Empty)) &&
                      (mySearch.Attribute("END").Value.Equals(events.EndDate) || events.EndDate.Equals(String.Empty)) &&
                      (mySearch.Attribute("COUNTRY").Value.Equals(events.Country) || events.Country.Equals(String.Empty)) &&
                      (mySearch.Attribute("CITY").Value.Equals(events.City) || events.City.Equals(String.Empty)) &&
                      (mySearch.Attribute("PRIZEPOOL").Value.Equals(events.PrizePool) || events.PrizePool.Equals(String.Empty)) &&
                      (mySearch.Attribute("DPC").Value.Equals(events.DpcPoints) || events.DpcPoints.Equals(String.Empty)) &&
                      (mySearch.Attribute("WINNER").Value.Equals(events.Winner) || events.Winner.Equals(String.Empty)) &&
                      (mySearch.Attribute("RUNNERUP").Value.Equals(events.RunnerUp) || events.RunnerUp.Equals(String.Empty)) &&
                      (mySearch.Attribute("NUMBEROFTEAMS").Value.Equals(events.NumberOfTeams) || events.NumberOfTeams.Equals(String.Empty)))
                      select new
                      {
                          value = (string)mySearch.Attribute("VALUE"),
                          name = (string)mySearch.Attribute("NAME"),
                          start = (string)mySearch.Attribute("START"),
                          end = (string)mySearch.Attribute("END"),
                          country = (string)mySearch.Attribute("COUNTRY"),
                          city = (string)mySearch.Attribute("CITY"),
                          prizepool = (string)mySearch.Attribute("PRIZEPOOL"),
                          dpc = (string)mySearch.Attribute("DPC"),
                          winner = (string)mySearch.Attribute("WINNER"),
                          runnerup = (string)mySearch.Attribute("RUNNERUP"),
                          numberofteams = (string)mySearch.Attribute("NUMBEROFTEAMS"),
                      };
            foreach(var match in res)
            {
                Events ev = new Events();
                ev.Value = match.value;
                ev.Name = match.name;
                ev.StartDate = match.start;
                ev.EndDate = match.end;
                ev.Country = match.country;
                ev.City = match.city;
                ev.PrizePool = match.prizepool;
                ev.DpcPoints = match.dpc;
                ev.Winner = match.winner;
                ev.RunnerUp = match.runnerup;
                ev.NumberOfTeams = match.numberofteams;
                find.Add(ev);
            }
            return find;
        }
    }
}
