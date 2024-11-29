using Microsoft.EntityFrameworkCore;
using ProjectForYp2.Model;

namespace ProjectForYp2.data
{
    class classdata
    {
        internal readonly UserContext userContext;

        public classdata()
        {
            userContext = new UserContext();
            databaseload();
        }

        private void databaseload()
        {
            userContext.Users.Load();
            userContext.Types.Load();
            userContext.Requests.Load();
            userContext.Comments.Load();
            userContext.OrgTechType.Load();
            userContext.Statys.Load();
        }

        private void databaseUpdate()
        {
            //userContext.Users.Update();

        }

        // Метод для доступа 
        public IEnumerable<User> GetUsers()
        {
            return userContext.Users.ToList();
        }
        public IEnumerable<Types> GetTypes()
        {
            return userContext.Types.ToList();
        }
        public IEnumerable<Requests> GetRequests()
        {
            return userContext.Requests.ToList();
        }
        public IEnumerable<Comment> GetComments()
        {
            return userContext.Comments.ToList();
        }
        public IEnumerable<OrgTechType> GetOrgTechType()
        {
            return userContext.OrgTechType.ToList();
        }
        public IEnumerable<Statys> GetStatys()
        {
            return userContext.Statys.ToList();
        }
    }
}
