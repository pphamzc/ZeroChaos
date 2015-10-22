using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ZeroChaos.Business.Entities;
using ZeroChaos.Service.Interface;

namespace ZeroChaos.Service.Services
{
    public class ResourceJobPreferenceService : IResourceJobPreferenceService
    {

        ResourceJobPreference rjp;
        ResourceJobPreferenceResponse rjpr;

        public ResourceJobPreferenceService()
        {
            rjp = new ResourceJobPreference();

            rjp.JobPreferenceStatusID = 1;
            rjp.JobPreferenceDateAvailable = new DateTime(2015, 1, 3);
            rjp.JobPreferencePreferredPay = 100.00;
            rjp.JobPreferenceMinimumPay = 100.00;
            rjp.JobPreferenceCurrencyCode = "USD";
            rjp.JobPreferenceDesiredPosition = "Manager";
            rjp.JobPreferenceWorkPreferencesID = 1;
            rjp.JobPreferenceWillingToRelocate = true;

            rjpr = new ResourceJobPreferenceResponse();
            rjpr.ResourceJobPreference = rjp;
            rjpr.jobCategory = new List<ObjectJobCategoryMapping>();

            ObjectJobCategoryMapping cat = new ObjectJobCategoryMapping();
            cat.JobCatID = 1;
            cat.ObjectID = 2;
            cat.ObjectJobCategoryMappingID = 3;
            cat.ObjectPKID = 4;

            rjpr.jobCategory.Add(cat);

            ResourceJobClassification reJobClass = new ResourceJobClassification();
            reJobClass.JobClassID = 1;
            reJobClass.ResourceJobClassificationID = 2;
            reJobClass.ResourceJobPreferenceID = 3;

            rjpr.jobClassification = new List<ResourceJobClassification>();
            rjpr.jobClassification.Add(reJobClass);

            rjpr.resourceIndustry = new List<ObjectIndustryMapping>();
            ObjectIndustryMapping indu = new ObjectIndustryMapping();
            indu.IndustryGroupID = 1;
            indu.ObjectID = 2;
            indu.ObjectIndustryMappingID = 3;
            indu.ObjectPKID = 5;

            rjpr.resourceIndustry.Add(indu);

            ResourceJobPreferenceCountry ctry = new ResourceJobPreferenceCountry();
            ctry.CountryCode = "US";
            ctry.ResourceJobPreferenceCountryID = 1;
            ctry.ResourceJobPreferenceID = 1;
            ctry.ResourcePreferenceForCountryID = 1;

            ResourceJobPreferenceCountry ctry2 = new ResourceJobPreferenceCountry();
            ctry.CountryCode = "EU";
            ctry.ResourceJobPreferenceCountryID = 2;
            ctry.ResourceJobPreferenceID = 2;
            ctry.ResourcePreferenceForCountryID = 2;

            rjpr.ResourceJobPreferenceCountry = new List<ResourceJobPreferenceCountry>();
            rjpr.ResourceJobPreferenceCountry.Add(ctry);
            rjpr.ResourceJobPreferenceCountry.Add(ctry2);


        }

        /// This method will return the resource job preferences details from ResourceJobPreference table based  on ResourceID
        public ResourceJobPreference GetResourceJobPreferenceByResourceID(int resourceID)
        {
            return rjp;
        }

        /// This method will add the resource job preference details in ResourceJobPreference table.
        public int AddUpdateResourceJobPreference(ResourceJobPreference resourceJobPreference)
        {
            return 1;
        }

        /// This method will update the resource job preference details.
        public bool UpdateResourceJobPreference(ResourceJobPreference resourceJobPreference)
        {
            return true;
        }

        /// This method will populate the Job Preference tab details of Resource Dossier.
        /// This method will return ResourceJobPreferenceResponse  which consist of Job Preference details
        public ResourceJobPreferenceResponse GetResourceJobPreferenceResponseByResourceID(int resourceID)
        {
            return rjpr;
        }



        //ResourceJobPreference IResourceJobPreferenceService.GetResourceJobPreferenceByResourceID(int resourceID)
        //{
        //    throw new NotImplementedException();
        //}

        public int AddResourceJobPreference(ResourceJobPreference resourceJobPreference)
        {
            throw new NotImplementedException();
        }

        //bool IResourceJobPreferenceService.UpdateResourceJobPreference(ResourceJobPreference resourceJobPreference)
        //{
        //    throw new NotImplementedException();
        //}

        //ResourceJobPreferenceResponse IResourceJobPreferenceService.GetResourceJobPreferenceResponseByResourceID(int resourceID)
        //{
        //    throw new NotImplementedException();
        //}
    }
}
