using GameMarketingProject.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameMarketingProject.Abstract
{
    public interface IOrderService
    {
        void Sale(Product product, Campaign campaign, Gamer gamer);
    }
}
