using System.Collections.Generic;
using FortSystems.Core.DomainObjects.Security.Validation;
using FortSystems.Core.Infrastructure;

namespace FortSystems.Core.DomainObjects.Security
{
    /// <summary>
    /// Classe que representa um usuário do sistema
    /// </summary>
    public class User : Entity  
    {
        /// <summary>
        /// Login de acesso ao sistema
        /// </summary>
        public virtual string Login { get; set; }

        /// <summary>
        /// Senha
        /// </summary>
        public virtual string Password { get; set; }

        /// <summary>
        /// Indica se o usuário está ou não ativo
        /// </summary>
        public virtual bool Active { get; set; }

        /// <summary>
        /// Retorna se o usuário possui informações validas para serem persistedas
        /// </summary>
        /// <param name="brokenRoles">lista de regras quebradas</param>
        /// <returns>se a entidade é válida ou não</returns>
        public override bool IsValid(out IList<string> brokenRoles)
        {
            return new UserValidator().Validate(this, out brokenRoles);
        }
    }
}
