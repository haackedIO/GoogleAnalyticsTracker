﻿using System.Web.Http;

namespace GoogleAnalyticsTracker.WebApi 
{
	public static class ConfigurationHelper
    {
		public static void RegisterTracker(this HttpConfiguration configuration, string trackingAccount)
        {
			configuration.Filters.Add(new ActionTrackingAttribute(trackingAccount));
		}

		public static void RegisterTracker(this HttpConfiguration configuration, Tracker tracker)
        {
			configuration.Filters.Add(new ActionTrackingAttribute(tracker));
		}
	}
}
