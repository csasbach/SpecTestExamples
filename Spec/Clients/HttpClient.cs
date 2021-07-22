using System;

namespace Spec.Clients
{
    public class HttpClient : IDisposable
    {
        private readonly Lazy<System.Net.Http.HttpClient> _currentHttpClientLazy;
        private bool _isDisposed;

        public HttpClient()
        {
            _currentHttpClientLazy = new Lazy<System.Net.Http.HttpClient>(CreateHttpClient);
        }

        public System.Net.Http.HttpClient Current => _currentHttpClientLazy.Value;
        
        private System.Net.Http.HttpClient CreateHttpClient()
        {
            var httpClient = new System.Net.Http.HttpClient();
            return httpClient;
        }
        
        public void Dispose()
        {
            if (_isDisposed)
            {
                return;
            }

            if (_currentHttpClientLazy.IsValueCreated)
            {
                Current.Dispose();
            }

            _isDisposed = true;
        }
    }
}