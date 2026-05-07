using System;
using Windows.ApplicationModel.Core;
using Windows.UI.Core;
using Windows.Web.Http;

namespace WinGoMapsX
{
    public static class AppCore
    {
        // Google Maps API configuration
        public static string GoogleMapAPIKey { get; set; } = "YOUR_API_KEY_HERE";
        public static string GoogleMapRequestsLanguage { get; set; } = "en";
        
        // Ariana API configuration for Persian text-to-speech
        public static string ArianaAPIKey { get; set; } = "YOUR_ARIANA_API_KEY_HERE";
        
        // HTTP client configuration
        private static HttpClient _httpClient;
        public static HttpClient HttpClient
        {
            get
            {
                if (_httpClient == null)
                {
                    _httpClient = new HttpClient();
                }
                return _httpClient;
            }
        }
        
        public static string HttpUserAgent { get; set; } = "WinGoMapsX/1.0";
        
        // UI Dispatcher
        public static CoreDispatcher Dispatcher
        {
            get
            {
                return CoreApplication.MainView.CoreWindow.Dispatcher;
            }
        }
    }
}
