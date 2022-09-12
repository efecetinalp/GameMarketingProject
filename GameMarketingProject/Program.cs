using GameMarketingProject.Concrete;
using GameMarketingProject.Entities;
using System;

namespace GameMarketingProject
{
    internal class Program
    {
        static void Main(string[] args)
        {
            GamerManager gamerManager = new GamerManager(new UserValidationManager());
            gamerManager.SignUp(new Gamer { Id = 0, BirthYear = 2000, IdentityNumber = 33333333333, LastName = "GGamer", Name = "Gamer" });

            CampaignManager campaignManager = new CampaignManager();
            campaignManager.Add(new Campaign { CampaignId = 1, CampaignName = "Summer Sales" });
            
            Product newProduct = new Product { Name = "2022 Game" };
            Campaign newCampaign = new Campaign { CampaignName = "Summer Sale" };
            Gamer newGamer = new Gamer { Name = "David" };
            OrderManager orderManager = new OrderManager();
            orderManager.Sale(newProduct, newCampaign, newGamer);
        }
    }
}
