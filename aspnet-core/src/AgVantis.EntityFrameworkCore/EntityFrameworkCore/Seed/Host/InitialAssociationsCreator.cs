using System.Linq;

namespace AgVantis.EntityFrameworkCore.Seed.Host
{
    public class InitialAssociationsCreator
    {
        private readonly AgVantisDbContext _context;
        public InitialAssociationsCreator(AgVantisDbContext context)
        {
            _context = context;
        }

        public void Create() 
        {
            var douglas = _context.associations.FirstOrDefault(p => p.EmailAddress == "douglas.adams@fortytwo.com");
            if (douglas == null)
            {
                _context.associations.Add(
                    new Association.Associations
                    {
                        Name = "Douglas",
                        EmailAddress = "douglas.adams@fortytwo.com"
                    });
            }
            var asimov = _context.associations.FirstOrDefault(p => p.EmailAddress == "isaac.asimov@fortytwo.com");
            if (douglas == null)
            {
                _context.associations.Add(
                    new Association.Associations
                    {
                        Name = "Isaac",
                        EmailAddress = "isaac.asimov@fortytwo.com"
                    });
            }
        }
    }
}
