using System;
using System.Collections.Generic;
using System.Text;

namespace GameProject
{
    interface IUserValidationService //Kullanıcıyı Doğrulamak.
    {
        bool Validate(Gamer gamer);

    }
}
