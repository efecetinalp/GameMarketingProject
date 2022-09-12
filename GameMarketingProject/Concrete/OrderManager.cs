using GameMarketingProject.Abstract;
using GameMarketingProject.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameMarketingProject.Concrete
{
    public class OrderManager : IOrderService
    {
        public void Sale(Product product, Campaign campaign, Gamer gamer)
        {
            Console.WriteLine(product.Name + " is sold to " + gamer.Name + " in " + campaign.CampaignName);
        }
    }
}
