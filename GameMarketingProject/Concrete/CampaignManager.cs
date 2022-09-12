using GameMarketingProject.Abstract;
using GameMarketingProject.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameMarketingProject.Concrete
{
    internal class CampaignManager : ICampaignService
    {
        public void Add(Campaign campaign)
        {
            Console.WriteLine("Campaign is created");
        }

        public void Remove(Campaign campaign)
        {
            Console.WriteLine("Campaign is deleted");
        }

        public void Update(Campaign campaign)
        {
            Console.WriteLine("Campaign is updated");
        }
    }
}
