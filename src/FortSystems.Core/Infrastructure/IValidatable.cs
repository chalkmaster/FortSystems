﻿using System.Collections.Generic;

namespace FortSystems.Core.Infrastructure
{
    /// <summary>
    /// Interface que permite um item ser ou não validado
    /// </summary>
    public interface IValidatable
    {
        /// <summary>
        /// Retorna se uma entidade possui informações validas para serem persistidas
        /// </summary>
        /// <param name="brokenRoles">lista de regras quebradas</param>
        /// <returns>se a entidade é válida ou não</returns>
        bool IsValid(out IList<string> brokenRoles);
    }
}
