﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ZeroChaos.Business.Entities;

namespace ZeroChaos.Service.Interface
{
    public interface IResourceJobPreferenceCountryService
    {
        /// This method will return the country names resource preferred to work or legally able to work.
        List<ResourceJobPreferenceCountry> GetResourceJobPreferenceCountryByJobPreferenceIDResourcePreferenceForCountryID(int jobPreferenceID, int resourcePreferenceForCountryID);

        /// This method will add the country resource preferred to work.
        int AddResourceJobPreferenceCountry(ResourceJobPreferenceCountry resourceJobPreferenceCountry);

        /// This method will update the country resource preferred to work.
        bool UpdateResourceJobPreferenceCountry(ResourceJobPreferenceCountry resourceJobPreferenceCountry);


    }
}
