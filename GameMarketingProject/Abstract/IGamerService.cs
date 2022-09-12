using GameMarketingProject.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameMarketingProject.Abstract
{
    public interface IGamerService
    {
        void SignUp(Gamer gamer);
        void LogIn(Gamer gamer);
        void Update(Gamer gamer);
        void Delete(Gamer gamer);
    }
}
