using System;
using System.Collections.Generic;
using System.Linq;
using FortSystems.Core.Extension;
using FortSystems.Core.Infrastructure;

namespace FortSystems.Core.DomainObjects.Security.Validation
{
    public class UserValidator: IValidator<User>
    {
        public const int LoginMinSize = 3;
        public const int LoginMaxSize = 20;

        public bool Validate(User entityToValidate, out IList<string> brokenRoles)
        {
            brokenRoles = new List<string>();

            if (String.IsNullOrWhiteSpace(entityToValidate.Login))
                brokenRoles.Add("Favor informar um login");
            else if (entityToValidate.Login.Length < LoginMinSize)
                brokenRoles.Add("O login deve ter pelo menos {0} caracteres".FormatWith(LoginMinSize));
            else if (entityToValidate.Login.Length > LoginMaxSize)
                brokenRoles.Add("O login deve ter no maximo {0} caracteres".FormatWith(LoginMaxSize));

            if(String.IsNullOrWhiteSpace(entityToValidate.Password))
                brokenRoles.Add("Você deve informar uma senha");

            return brokenRoles.Any();
        }
    }
}
