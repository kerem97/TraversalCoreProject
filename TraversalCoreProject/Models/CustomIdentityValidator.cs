using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TraversalCoreProject.Models
{
    public class CustomIdentityValidator : IdentityErrorDescriber
    {
        public override IdentityError PasswordTooShort(int length)
        {
            return new IdentityError()
            {
                Code = "PasswordTooShort",
                Description = $"Parola Minimum {length} karakter olmalıdır "
            };
        }
    }
}
