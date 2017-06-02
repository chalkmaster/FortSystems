using System;
using System.Collections.Generic;
using FortSystems.Core.DomainObjects.Security;
using NHibernate;
using NHibernate.Criterion;

namespace FortSystems.Core.Infrastructure.Repository.NHibernate
{
    public class UserRepository: Repository<User>, IUserRepository
    {
        public UserRepository(ISession session) : base(session)
        {
        }

        public User FindByLogin(string login)
        {
            var query = Session.QueryOver<User>();
            return query.Where(user => user.Login.Equals(login, StringComparison.InvariantCultureIgnoreCase)
                                       && user.Deleted == false)
                                       .SingleOrDefault();

        }

        public IList<User> FindAll()
        {
            var query = Session.QueryOver<User>();
            return query.Where(user => user.Deleted == false).List();
        }
    }
}
