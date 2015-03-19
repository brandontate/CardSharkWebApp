using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Web;

namespace CardSharkWebApp2.Models
{
    public class ModelConfigurations
    {
        public class OrganizationConfiguration : EntityTypeConfiguration<Organization>
        {
            public OrganizationConfiguration()
            {
                Property(o => o.ID);
                Property(o => o.Name).IsRequired().HasMaxLength(10);
            }
        }

        public class EventConfiguration : EntityTypeConfiguration<Event>
        {
            public EventConfiguration()
            {
                Property(e => e.ID);
                Property(e => e.Name).IsRequired().HasMaxLength(50);
                Property(e => e.Date).IsRequired();
            }
        }

        public class MatchConfiguration : EntityTypeConfiguration<Match>
        {
            public MatchConfiguration()
            {
                Property(m => m.ID);
                Property(m => m.FirstOppenent).IsRequired();
                Property(m => m.SecondOppenent).IsRequired();
                Property(m => m.Winner);
            }
        }

        public class PredictionConfiguration : EntityTypeConfiguration<Prediction>
        {
            public PredictionConfiguration()
            {
                Property(p => p.ID);
                Property(p => p.Guess);
                Property(p => p.MatchID).IsRequired();
                Property(p => p.UserID).IsRequired();   
            }
        }
    }
}