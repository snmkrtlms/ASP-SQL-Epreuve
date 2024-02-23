namespace ASP_Epreuve_ASP_SQL.Handlers
{
    public abstract class SessionManager
    {
        protected readonly ISession _session;

        public SessionManager(IHttpContextAccessor httpContextAccessor)
        {
            _session = httpContextAccessor.HttpContext.Session;
        }
    }

}
