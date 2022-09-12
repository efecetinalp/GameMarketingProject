using GameMarketingProject.Abstract;
using GameMarketingProject.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameMarketingProject.Concrete
{
    internal class GamerManager : IGamerService
    {
        IUserValidationService _userValidationService;

        public GamerManager(IUserValidationService userValidationService)
        {
            _userValidationService = userValidationService;
        }

        public void Delete(Gamer gamer)
        {
            Console.WriteLine("user deleted");
        }

        public void LogIn(Gamer gamer)
        {
            Console.WriteLine("user logged-in");
        }

        public void SignUp(Gamer gamer)
        {
            if (_userValidationService.Validate(gamer))
            {
                Console.WriteLine("user validation is success");
                Console.WriteLine("user signed-up");
            }
            else
                Console.WriteLine("user validation is failed");
        }

        public void Update(Gamer gamer)
        {
            Console.WriteLine("user updated");
        }
    }
}
