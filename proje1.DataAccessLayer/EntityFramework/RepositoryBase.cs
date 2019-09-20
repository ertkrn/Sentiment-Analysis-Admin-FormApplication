namespace proje1.DataAccessLayer.EntityFramework
{
    public class RepositoryBase
    {
        protected static YorumlarContext context;
        private static object _lockSync = new object();

        protected RepositoryBase()
        {
            CreateContext();
        }

        private static void CreateContext()
        {
            if (context == null)
            {
                lock (_lockSync)
                {
                    if(context == null)
                    {
                        context = new YorumlarContext();
                    }
                }
            }
        }
    }
}
