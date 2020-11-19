using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace EventsDota
{
     class DOM:IStrategy
    {
        public List<Events> AnalyzeFile(Events events)
        {
            List<Events> find = new List<Events>();
            XmlDocument doc = new XmlDocument();
            doc.Load(@"D:\Proga\EventsDota\EventsDota\bin\Debug\EventsDataBase.xml");
            XmlNode node = doc.DocumentElement;
            foreach (XmlNode nod in node.ChildNodes)
            {
                string Value = "";
                string Name = "";
                string StartDate = "";
                string EndDate = "";
                string Country = "";
                string City = "";
                string PrizePool = "";
                string DpcPoints = "";
                string Winner = "";
                string RunnerUp = "";
                string NumberOfTeams = "";

                foreach (XmlAttribute attribute in nod.Attributes)
                {
                    if (attribute.Name.Equals("VALUE") && (attribute.Value.Equals(events.Value) || events.Value.Equals(String.Empty)))
                    {
                        Value = attribute.Value;
                    }
                    if (attribute.Name.Equals("NAME") && (attribute.Value.Equals(events.Name) || events.Name.Equals(String.Empty)))
                    {
                        Name = attribute.Value;
                    }
                    if (attribute.Name.Equals("START") && (attribute.Value.Equals(events.StartDate) || events.StartDate.Equals(String.Empty)))
                    {
                        StartDate = attribute.Value;
                    }
                    if (attribute.Name.Equals("END") && (attribute.Value.Equals(events.EndDate) || events.EndDate.Equals(String.Empty)))
                    {
                        EndDate = attribute.Value;
                    }
                    if (attribute.Name.Equals("COUNTRY") && (attribute.Value.Equals(events.Country) || events.Country.Equals(String.Empty)))
                    {
                        Country = attribute.Value;
                    }
                    if (attribute.Name.Equals("CITY") && (attribute.Value.Equals(events.City) || events.City.Equals(String.Empty)))
                    {
                        City = attribute.Value;
                    }
                    if (attribute.Name.Equals("PRIZEPOOL") && (attribute.Value.Equals(events.PrizePool) || events.PrizePool.Equals(String.Empty)))
                    {
                        PrizePool = attribute.Value;
                    }
                    if (attribute.Name.Equals("DPC") && (attribute.Value.Equals(events.DpcPoints) || events.DpcPoints.Equals(String.Empty)))
                    {
                        DpcPoints = attribute.Value;
                    }
                    if (attribute.Name.Equals("WINNER") && (attribute.Value.Equals(events.Winner) || events.Winner.Equals(String.Empty)))
                    {
                        Winner = attribute.Value;
                    }
                    if (attribute.Name.Equals("RUNNERUP") && (attribute.Value.Equals(events.RunnerUp) || events.RunnerUp.Equals(String.Empty)))
                    {
                        RunnerUp = attribute.Value;
                    }
                    if (attribute.Name.Equals("NUMBEROFTEAMS") && (attribute.Value.Equals(events.NumberOfTeams) || events.NumberOfTeams.Equals(String.Empty)))
                    {
                        NumberOfTeams = attribute.Value;
                    }
                }

                if (Value != "" && Name != "" && StartDate != "" && EndDate != "" && Country != "" && City != "" && PrizePool != "" && DpcPoints != ""
                            && Winner != "" && RunnerUp != "" && NumberOfTeams != "")
                {
                    Events ev = new Events();
                    ev.Value = Value;
                    ev.Name = Name;
                    ev.StartDate = StartDate;
                    ev.EndDate = EndDate;
                    ev.Country = Country;
                    ev.City = City;
                    ev.PrizePool = PrizePool;
                    ev.DpcPoints = DpcPoints;
                    ev.Winner = Winner;
                    ev.RunnerUp = RunnerUp;
                    ev.NumberOfTeams = NumberOfTeams;

                    find.Add(ev);
                }
            }
            return find;
        }
    }
}
