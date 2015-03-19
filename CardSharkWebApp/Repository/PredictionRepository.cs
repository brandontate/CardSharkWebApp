using CardSharkWebApp2.Data;
using CardSharkWebApp2.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace CardSharkWebApp2.Repository
{
    public class PredictionRepository
    {
        private CardContext _dbContext;
        public static PredictionRepository guessRepo = new PredictionRepository();

        public PredictionRepository()
        {
            _dbContext = new CardContext();
            _dbContext.Matches.Load();

        }

        public CardContext Context()
        {
            return _dbContext;
        }


        public DbSet<Match> GetDbSet()
        {
            return _dbContext.Matches;
        }

        //public void Update(Match M, string current)
        //{
        //    if (M.Guess != current)
        //    {
        //        M.Guess = current;
        //        using (var context = new CardContext())
        //        {
        //            context.Entry(M).State = System.Data.Entity.EntityState.Modified;
        //            context.SaveChanges();
        //        }
        //    }

        //}

        //public void UpdateGuess(List<ComboBox> guessComboBoxes)
        //{
        //    foreach (var combobox in guessComboBoxes)
        //    {
        //        if (combobox.SelectedIndex != -1)
        //        {
        //            int matchID = Convert.ToInt32(combobox.Name.Substring(combobox.Name.LastIndexOf('_') + 1));
        //            string guessed = combobox.SelectedItem.ToString();
        //            using (var context = new CardContext())
        //            {
        //                var query = (from m in context.Matches
        //                             where m.id == matchID
        //                             select m);
        //                foreach (var item in query)
        //                {
        //                    guessRepo.Update(item, guessed);
        //                }
        //            }
        //        }
        //    }
        //}

        //public List<ComboBox> FindCardComboBoxes(Grid name)
        //{
        //    var children = name.Children;
        //    List<ComboBox> guessComboBoxes = new List<ComboBox>();
        //    foreach (var child in children)
        //    {
        //        if (child.GetType() == typeof(ComboBox))
        //        {
        //            guessComboBoxes.Add((ComboBox)child);
        //        }
        //    }
        //    return guessComboBoxes;
        //}

        public int GetEventID(string checkEvent)
        {
            using (var context = new CardContext())
            {
                foreach (var eventItem in context.Events)
                {
                    var year = eventItem.Date.Year;
                    var month = eventItem.Date.Month;
                    var day = eventItem.Date.Day;
                    string eventName = String.Format("{0} ({1}/{2}/{3})", eventItem.Name, month, day, year);
                    if (checkEvent == eventName)
                    {
                        return eventItem.ID;
                    }
                }
            }
            throw new ArgumentException();
        }

        public int GetOrganizationID(string company)
        {
            using (var context = new CardContext())
            {
                foreach (var organization in context.Organizations)
                {
                    if (company == organization.Name)
                    {
                        return organization.ID;
                    }
                }
            }
            throw new ArgumentException();
        }

        public List<string> GetOrganizations()
        {
            var organizationList = new List<string>();

            using (var context = new CardContext())
            {
                var query = from o in context.Organizations
                            orderby o.Name
                            select o;

                foreach (var organization in query)
                {
                    organizationList.Add(organization.Name);
                }
            }
            return organizationList;
        }

        public List<string> GetEvents(int companyID)
        {
            var eventList = new List<string>();
            using (var context = new CardContext())
            {
                var query = (from e in context.Events
                             orderby e.Date
                             select e).ToList();
                foreach (var eventItem in query)
                {
                    if (companyID == eventItem.OrganizationID)
                    {
                        var year = eventItem.Date.Year;
                        var month = eventItem.Date.Month;
                        var day = eventItem.Date.Day;
                        string eventName = String.Format("{0} ({1}/{2}/{3})", eventItem.Name, month, day, year);
                        eventList.Add(eventName);
                    }
                }
            }
            return eventList;
        }

        //public List<Match> GetEventCard(int eventID)
        //{
        //    List<Match> eventMatches = new List<Match>();
        //    using (var context = new CardContext())
        //    {
        //        var matches = (from e in context.Events
        //                       join m in context.Matches
        //                       on e.ID equals m.EventID
        //                       where m.EventID == eventID
        //                       select new
        //                       {
        //                           e_ID = m.EventID,
        //                           match_id = m.ID,
        //                           guess = m.Guess,
        //                           winner = m.Winner,
        //                           first = m.FirstOppenent,
        //                           second = m.SecondOppenent,
        //                           date = e.Date
        //                       }).ToList();
        //        foreach (var match in matches)
        //        {
        //            eventMatches.Add(
        //                new Match
        //                {
        //                    ID = match.match_id,
        //                    FirstOppenent = match.first,
        //                    SecondOppenent = match.second,
        //                    Guess = match.guess,
        //                    Winner = match.winner,
        //                    EventID = match.e_ID
        //                    //EventDate = match.date
        //                });
        //        }
        //    }
        //    return eventMatches;
        //}


        //public string CalculateEventAccuracy(int matchID)
        //{
        //    using (var context = new CardContext())
        //    {
        //        string percentString = "";

        //        int correct = (from m in context.Matches
        //                       where ((m.Winner == m.Guess) && (m.EventID == eventID) && (m.Winner != null))
        //                       select m).Count();

        //        int total = (from m in context.Predictions
        //                     where ((m.MatchID == matchID) && (m.Guess != null) && (m.Guess != "Not Sure"))
        //                     select m).Count();

        //        if (total != 0)
        //        {
        //            percentString = string.Format("{0:0%}", ((double)correct / total));
        //        }

        //        return percentString;
        //    }
        //}

        public string RetrieveSavedGuess(int matchID)
        {
            string savedGuess = "";
            using (var context = new CardContext())
            {
                var query = from m in context.Predictions
                            where m.ID == matchID
                            select m;
                foreach (var item in query)
                {
                    savedGuess = item.Guess;
                }
            }
            return savedGuess;
        }
    }
}