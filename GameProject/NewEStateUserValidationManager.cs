using System;
using System.Collections.Generic;
using System.Text;

namespace GameProject
{
    // Başka bir sisteme geçildiği zaman;
    class NewEStateUserValidationManager : IUserValidationService
    {
        public bool Validate(Gamer gamer)
        {
            return true;
        }
    }
}
