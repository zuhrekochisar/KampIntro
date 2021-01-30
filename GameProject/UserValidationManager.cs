using System;
using System.Collections.Generic;
using System.Text;

namespace GameProject
{
    class UserValidationManager : IUserValidationService
    {
        public bool Validate(Gamer gamer)
        {
            if (gamer.BirthYear == 1997 && gamer.FirstName == "ZÜHRE" && gamer.LastName == "KOÇHİSAR" && gamer.IdentityNumber == 12345678900)
            {
                return true;
            }
            else
            {
               return false;
            }
        }
    }
}
