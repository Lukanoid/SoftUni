using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using InfluencerManagerApp.Core.Contracts;
using InfluencerManagerApp.Models;
using InfluencerManagerApp.Models.Contracts;
using InfluencerManagerApp.Repositories;
using InfluencerManagerApp.Repositories.Contracts;
using InfluencerManagerApp.Utilities.Messages;

namespace InfluencerManagerApp.Core
{
    public class Controller : IController
    {
        private IRepository<IInfluencer> influencers;
        private IRepository<ICampaign> campaigns;
        private List<string> validInfluencers = new List<string>() { "BusinessInfluencer", "FashionInfluencer", "BloggerInfluencer" };
        private List<string> validCampaigns = new List<string>() { "ProductCampaign", "ServiceCampaign" };

        public Controller()
        {
            influencers = new InfluencerRepository();
            campaigns = new CampaignRepository();
        }

        public string RegisterInfluencer(string typeName, string username, int followers)
        {
            if (!validInfluencers.Contains(typeName))
            {
                return string.Format(OutputMessages.InfluencerInvalidType, typeName);
            }

            IInfluencer influencerExist = influencers.FindByName(username);

            if (influencerExist != null)
            {
                return string.Format(OutputMessages.UsernameIsRegistered, username, influencers.GetType().Name);
            }

            IInfluencer influencer = null;
            switch (typeName)
            {
                case "BusinessInfluencer":
                    influencer = new BusinessInfluencer(username, followers);
                    break;
                case "FashionInfluencer":
                    influencer = new FashionInfluencer(username, followers);
                    break;
                case "BloggerInfluencer":
                    influencer = new BloggerInfluencer(username, followers);
                    break;
            }

            influencers.AddModel(influencer);
            return string.Format(OutputMessages.InfluencerRegisteredSuccessfully, username);
        }

        public string BeginCampaign(string typeName, string brand)
        {
            if (!validCampaigns.Contains(typeName))
            {
                return string.Format(OutputMessages.CampaignTypeIsNotValid, typeName);
            }
            //TODO
            if (campaigns.FindByName(brand) != null)
            {
                return string.Format(OutputMessages.CampaignDuplicated, brand);
            }

            ICampaign campaign = null;

            switch (typeName)
            {
                case "ProductCampaign":
                    campaign = new ProductCampaign(brand);
                    break;
                case "ServiceCampaign":
                    campaign = new ServiceCampaign(brand);
                    break;
            }

            campaigns.AddModel(campaign);
            return string.Format(OutputMessages.CampaignStartedSuccessfully, brand, typeName);
        }

        public string AttractInfluencer(string brand, string username)
        {
            IInfluencer influencer = influencers.FindByName(username);
            if (influencer == null)
            {
                return string.Format(OutputMessages.InfluencerNotFound, influencers.GetType().Name, username);
            }
            ICampaign campaign = campaigns.FindByName(brand);
            if (campaign == null)
            {
                return string.Format(OutputMessages.CampaignNotFound, brand);
            }
            if (campaign.Contributors.Contains(username))
            {
                return string.Format(OutputMessages.InfluencerAlreadyEngaged, username, brand);
            }

            if ((campaign is ProductCampaign && !(influencer is BusinessInfluencer || influencer is FashionInfluencer)) ||
                (campaign is ServiceCampaign && !(influencer is BusinessInfluencer || influencer is BloggerInfluencer)))
            {
                return $"{username} is not eligible for the {brand} campaign.";
            }

            if (campaign.Budget < influencer.CalculateCampaignPrice())
            {
                return string.Format(OutputMessages.UnsufficientBudget, brand, username);
            }

            influencer.EarnFee(influencer.CalculateCampaignPrice());
            influencer.EnrollCampaign(brand);
            campaign.Engage(influencer);

            return string.Format(OutputMessages.InfluencerAttractedSuccessfully, username, brand);
        }

        public string FundCampaign(string brand, double amount)
        {
            ICampaign campaign = campaigns.FindByName(brand);
            if (campaign == null)
            {
                return string.Format(OutputMessages.InvalidCampaignToFund);
            }
            //CHECK IF ZERO IS INCLUSIVE
            if (amount <= 0)
            {
                return string.Format(OutputMessages.NotPositiveFundingAmount);
            }
            campaign.Gain(amount);
            return string.Format(OutputMessages.CampaignFundedSuccessfully, brand, amount);
        }

        public string CloseCampaign(string brand)
        {
            ICampaign campaign = campaigns.FindByName(brand);
            if (campaign == null)
            {
                return string.Format(OutputMessages.InvalidCampaignToClose);
            }

            if (campaign.Budget <= 10000)
            {
                return string.Format(OutputMessages.CampaignCannotBeClosed, brand);
            }

            foreach (var contributor in campaign.Contributors)
            {
                IInfluencer influencer = influencers.FindByName(contributor);
                influencer.EarnFee(2000);
                influencer.EndParticipation(brand);
            }

            return string.Format(OutputMessages.CampaignClosedSuccessfully, brand);
        }

        public string ConcludeAppContract(string username)
        {
            IInfluencer influencer = influencers.FindByName(username);
            if (influencer == null)
            {
                return string.Format(OutputMessages.InfluencerNotSigned, username);
            }

            if (influencer.Participations.Any())
            {
                return string.Format(OutputMessages.InfluencerHasActiveParticipations, username);
            }

            influencers.RemoveModel(influencer);
            return string.Format(OutputMessages.ContractConcludedSuccessfully, username);
        }

        public string ApplicationReport()
        {
            StringBuilder sb = new StringBuilder();
            foreach (var influencer in influencers.Models.OrderByDescending(x=>x.Income).ThenByDescending(x=>x.Followers))
            {
                sb.AppendLine(
                    $"{influencer.Username} - Followers: {influencer.Followers}, Total Income: {influencer.Income}");
                if (influencer.Participations.Any())
                {
                    sb.AppendLine("Active Campaigns:");
                    foreach (var allCampaings in influencer.Participations.OrderBy(x=>x))
                    {
                        ICampaign currentCampaign = campaigns.FindByName(allCampaings);
                        sb.AppendLine(
                            $"--{currentCampaign.GetType().Name} - Brand: {currentCampaign.Brand}, Budget: {currentCampaign.Budget}, Contributors: {currentCampaign.Contributors.Count}");
                    }
                }
            }

            return sb.ToString().TrimEnd();
        }
    }
}
