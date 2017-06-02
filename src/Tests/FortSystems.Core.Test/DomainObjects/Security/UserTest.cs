using FortSystems.Core.DomainObjects.Security;
using FortSystems.Core.Infrastructure.Repository.Helper;
using FortSystems.Core.Infrastructure.Repository.NHibernate;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace FortSystems.Core.Test.DomainObjects.Security
{

    [TestClass]
    public class UserTest
    {
        
        [TestMethod]
        [ExpectedException(typeof(NHibernate.PropertyValueException))]
        public void LoginDeveSerInformado()
        {
            using (var session = PersistenceHelper.OpenSession())
            {
                var user = new User {Password = "2424"};
                var userRepository = new UserRepository(session);
                userRepository.CreateOrUpdate(user);
            }
        }

        [TestMethod]
        [ExpectedException(typeof(NHibernate.PropertyValueException))]
        public void SenhaDeveSerInformada()
        {
            using (var session = PersistenceHelper.OpenSession())
            {
                var user = new User {Login = "666"};
                var userRepository = new UserRepository(session);
                userRepository.CreateOrUpdate(user);

            }
        }

        [TestMethod]
        public void UsurioSalvaCorretamente()
        {
            using (var session = PersistenceHelper.OpenSession())
            {
                var user = new User { Active = true,
                                      Deleted = false,
                                      ExternalCode = "1234",
                                      Login = "Teste", 
                                      Password = "12345" 
                                    };

                var userRepository = new UserRepository(session);
                
                userRepository.CreateOrUpdate(user);

                Assert.AreNotEqual(0, user.Id);
            }
        }
    }
}
