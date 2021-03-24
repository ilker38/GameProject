using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Channels;

namespace GameProject
{
    class UserValidationManager:IUserValidationService
    {
        public bool Validate(Gamer gamer)
        {
            if (
                gamer.BirthYear == 1985 && gamer.FirstName == "ilker" && gamer.LastName == "Uras" &&
                gamer.IdentityNumber == 99966688845)
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
