namespace CardSharkWebApp2.Migrations
{
    using CardSharkWebApp2.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.Migrations;
using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<CardSharkWebApp2.Data.CardContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
        }

        protected override void Seed(CardSharkWebApp2.Data.CardContext context)
        {
            {

                //  This method will be called after migrating to the latest version.
                //  You can use the DbSet<T>.AddOrUpdate() helper extension method 
                //  to avoid creating duplicate seed data. E.g.
                //
                //    context.People.AddOrUpdate(
                //      p => p.FullName,
                //      new Person { FullName = "Andrew Peters" },
                //      new Person { FullName = "Brice Lambson" },
                //      new Person { FullName = "Rowan Miller" }
                //    );
                //

                context.Organizations.Add(new Organization
                {
                    ID = 1,
                    Name = "WWE",
                    Events = new List<Event>
                {
                    new Event
                    {
                        ID = 1,
                        Name = "Royal Rumble",
                        Date = new DateTime(2015, 01, 25, 19, 0, 0),
                        Matches = new List<Match> 
                        {
                            new Match
                            {
                                FirstOppenent = "The Bella Twins",
                                SecondOppenent = "Paige",
                                Winner = "The Bella Twins"
                            }
                        }
                    },

                    new Event
                    {
                        ID = 2,
                        Name = "Fastlane",
                        Date = new DateTime(2015, 02, 22, 19, 0, 0),
                        Matches = new List<Match>
                        {
                            new Match
                            {
                                FirstOppenent = "Daniel Bryan",
                                SecondOppenent = "Roman Reigns",
                                Winner = "Daniel Bryan"
                            }
                        }
                    },

                    new Event
                    {
                        ID = 3,
                        Name = "TLC",
                        Date = new DateTime(2014, 12, 14, 19, 0, 0),
                        Matches = new List<Match>
                        {
                            new Match
                            {
                                FirstOppenent = "The New Day",
                                SecondOppenent = "Goldust & Stardust",
                                Winner = "The New Day"
                            },

                            new Match
                            {
                                FirstOppenent = "Dolph Ziggler",
                                SecondOppenent = "Luke Harper",
                                Winner = "Dolph Ziggler"
                            },

                            new Match
                            {
                                FirstOppenent = "The Usos",
                                SecondOppenent = "The Miz & Damien Mizdow",
                                Winner = "The Usos"
                            },

                            new Match
                            {
                                FirstOppenent = "Big Show",
                                SecondOppenent = "Erick Rowan",
                                Winner = "Big Show"
                            },

                            new Match
                            {
                                FirstOppenent = "John Cena",
                                SecondOppenent = "Seth Rollins",
                                Winner = "John Cena"
                            },

                            new Match
                            {
                                FirstOppenent = "Nikki Bella",
                                SecondOppenent = "AJ Lee",
                                Winner = "Nikki Bella"
                            },

                            new Match
                            {
                                FirstOppenent = "Ryback",
                                SecondOppenent = "Kane",
                                Winner = "Ryback"
                            },

                            new Match
                            {
                                FirstOppenent = "Rusev",
                                SecondOppenent = "Jack Swagger",
                                Winner = "Rusev"
                            },

                            new Match
                            {
                                FirstOppenent = "Bray Wyatt",
                                SecondOppenent = "Dean Ambrose",
                                Winner = "Bray Wyatt"
                            }
                        }
                    }
                }
                });

                context.Organizations.Add(new Organization
                {
                    ID = 2,
                    Name = "UFC",
                    Events = new List<Event>
                {
                    new Event
                    {
                        ID = 1,
                        Name = "UFC 183",
                        Date = new DateTime(2015,01,31,19,0,0),
                        Matches = new List<Match>
                        {
                            new Match { FirstOppenent = "Anderson 'The Spider' Silva", SecondOppenent = "Nick Diaz", Winner = "Anderson 'The Spider' Silva"}
                        }
                    },

                    new Event
                    {
                        ID = 2,
                        Name = "UFC 184",
                        Date = new DateTime(2015,02,28,19,0,0),
                        Matches = new List<Match>
                        {
                            new Match { FirstOppenent = "Masio Fullen", SecondOppenent = "Alexander Torres" },
                            new Match { FirstOppenent = "James Krause", SecondOppenent = "Valmir Lazaro" },
                            new Match { FirstOppenent = "Derrick Lewis", SecondOppenent = "Ruan Potts" },
                            new Match { FirstOppenent = "Dhiego Lima", SecondOppenent = "Tim Means" },
                            new Match { FirstOppenent = "Roman Salazar", SecondOppenent = "Norifumi Yamamoto" },
                            new Match { FirstOppenent = "Mark Muñoz", SecondOppenent = "Roan Carneiro" },
                            new Match { FirstOppenent = "Tony Ferguson", SecondOppenent = "Gleison Tibau" },
                            new Match { FirstOppenent = "Alan Jouban", SecondOppenent = "Richard Walsh" },
                            new Match { FirstOppenent = "Jake Ellenberger", SecondOppenent = "Josh Koscheck" },
                            new Match { FirstOppenent = "Raquel Pennington", SecondOppenent = "Holly Holm" },
                            new Match { FirstOppenent = "Rhonda Rousey", SecondOppenent = "Catt Zigano" }   
                        }
                    },

                    new Event
                    {
                        ID = 3,
                        Name = "UFC Test",
                        Date = new DateTime(2015,01,31,19,0,0),
                        Matches = new List<Match>
                        {
                        }
                    }
                }
                });
            }
        }
    }
}
 
