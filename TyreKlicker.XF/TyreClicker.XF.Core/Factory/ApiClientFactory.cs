using System;
using System.Threading;
using TyreKlicker.XF.Core.Services;

namespace TyreKlicker.XF.Core.Factory
{
    internal static class ApiClientFactory
    {
        private static Uri apiUri;

        private static Lazy<ApiClient> apiClient = new Lazy<ApiClient>(
          () => new ApiClient(apiUri),
          LazyThreadSafetyMode.ExecutionAndPublication);

        static ApiClientFactory()
        {
            apiUri = new Uri("https://localhost:44310");
        }

        public static ApiClient Instance
        {
            get
            {
                return apiClient.Value;
            }
        }
    }
}