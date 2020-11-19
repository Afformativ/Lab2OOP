using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace EventsDota
{
    class SAX:IStrategy
    {
        public List<Events> AnalyzeFile(Events events)
        {
            List<Events> find = new List<Events>();
            var xmlReader = new XmlTextReader((@"D:\Proga\EventsDota\EventsDota\bin\Debug\EventsDataBase.xml"));

            while (xmlReader.Read())
            {
                if (xmlReader.HasAttributes)
                {
                    while (xmlReader.MoveToNextAttribute())
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

                        if (xmlReader.Name.Equals("VALUE") && (xmlReader.Value.Equals(events.Value) || events.Value.Equals(String.Empty)))
                        {
                            Value = xmlReader.Value;
                            xmlReader.MoveToNextAttribute();
                            if (xmlReader.Name.Equals("NAME") && (xmlReader.Value.Equals(events.Name) || events.Name.Equals(String.Empty)))
                            {
                                Name = xmlReader.Value;
                                xmlReader.MoveToNextAttribute();

                                if (xmlReader.Name.Equals("START") && (xmlReader.Value.Equals(events.StartDate) || events.StartDate.Equals(String.Empty)))
                                {
                                    StartDate = xmlReader.Value;
                                    xmlReader.MoveToNextAttribute();
                                    if (xmlReader.Name.Equals("END") && (xmlReader.Value.Equals(events.EndDate) || events.EndDate.Equals(String.Empty)))
                                    {
                                        EndDate = xmlReader.Value;
                                        xmlReader.MoveToNextAttribute();
                                        if (xmlReader.Name.Equals("COUNTRY") && (xmlReader.Value.Equals(events.Country) || events.Country.Equals(String.Empty)))
                                        {
                                            Country = xmlReader.Value;
                                            xmlReader.MoveToNextAttribute();
                                            if (xmlReader.Name.Equals("CITY") && (xmlReader.Value.Equals(events.City) || events.City.Equals(String.Empty)))
                                            {
                                                City = xmlReader.Value;
                                                xmlReader.MoveToNextAttribute();
                                                if (xmlReader.Name.Equals("PRIZEPOOL") && (xmlReader.Value.Equals(events.PrizePool) || events.PrizePool.Equals(String.Empty)))
                                                {
                                                    PrizePool = xmlReader.Value;
                                                    xmlReader.MoveToNextAttribute();
                                                    if (xmlReader.Name.Equals("DPC") && (xmlReader.Value.Equals(events.DpcPoints) || events.DpcPoints.Equals(String.Empty)))
                                                    {
                                                        DpcPoints = xmlReader.Value;
                                                        xmlReader.MoveToNextAttribute();
                                                        if (xmlReader.Name.Equals("WINNER") && (xmlReader.Value.Equals(events.Winner) || events.Winner.Equals(String.Empty)))
                                                        {
                                                            Winner = xmlReader.Value;
                                                            xmlReader.MoveToNextAttribute();
                                                            if (xmlReader.Name.Equals("RUNNERUP") && (xmlReader.Value.Equals(events.RunnerUp) || events.RunnerUp.Equals(String.Empty)))
                                                            {
                                                                RunnerUp = xmlReader.Value;
                                                                xmlReader.MoveToNextAttribute();
                                                                if (xmlReader.Name.Equals("NUMBEROFTEAMS") && (xmlReader.Value.Equals(events.NumberOfTeams) || events.NumberOfTeams.Equals(String.Empty)))
                                                                {
                                                                    PrizePool = xmlReader.Value;
                                                                }
                                                            }
                                                        }
                                                    }
                                                }
                                            }
                                        }
                                    }
                                }
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
                }
            }

            xmlReader.Close();
            return find;
        }
    }
}
