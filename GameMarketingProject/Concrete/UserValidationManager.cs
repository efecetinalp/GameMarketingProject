using GameMarketingProject.Abstract;
using GameMarketingProject.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameMarketingProject.Concrete
{
    public class UserValidationManager : IUserValidationService
    {
        public bool Validate(Gamer gamer)
        {
            if (gamer.BirthYear <= 2010 && gamer.IdentityNumber == 33333333333 && gamer.Name == "Gamer" && gamer.LastName == "GGamer")
            {
                return true;
            }
            else
                return false;
        }
    }
}
