namespace AgVantis.EntityFrameworkCore.Seed.Host
{
    public class InitialHostDbBuilder
    {
        private readonly AgVantisDbContext _context;

        public InitialHostDbBuilder(AgVantisDbContext context)
        {
            _context = context;
        }

        public void Create()
        {
            new DefaultEditionCreator(_context).Create();
            new DefaultLanguagesCreator(_context).Create();
            new HostRoleAndUserCreator(_context).Create();
            new DefaultSettingsCreator(_context).Create();
            new InitialAssociationsCreator(_context).Create();

            _context.SaveChanges();
        }
    }
}
