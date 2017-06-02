using System.Collections.Generic;
using FortSystems.Core.DomainObjects.Security;

namespace FortSystems.Core.Infrastructure.Repository
{
    /// <summary>
    /// Interface de contrato para o repositório de usuário
    /// </summary>
    public interface IUserRepository: IRepository<User>
    {
        /// <summary>
        /// Localiza um usuário pelo seu login
        /// </summary>
        /// <param name="login">login do usuário a ser localizado</param>
        /// <returns>usuário que possui o login exatamente conforme informado</returns>
        User FindByLogin(string login);

        /// <summary>
        /// Retorna todos os usuários do sistema
        /// </summary>
        /// <returns>Lista de usuário</returns>
        IList<User> FindAll();
    }
}
