using RestAllegro.Authorization;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RestAllegro.Client
{
    public interface ITokenManager
    {
        string GetUserToken();
        string GetApplicationToken();
        string GetBasePath();
        string GetApiClientId();
        string GetBasePath(Client.ApiType type);
        string GetBasicToken();
    }
    public abstract class RESTTokenManager : ITokenManager
    {
        private static List<AccountToken> _accountTokens;
        private static ApplicationToken _appicationToken;
        private static RESTAllegroEnvironment _environment;
        public int ClientTokenId;
        public RESTTokenManager(int clientTokenId)
        {
            ClientTokenId = clientTokenId;
            _environment = SetRESTAllegroEnvironment();
            if (_accountTokens == null) _accountTokens = new List<AccountToken>();
        }
        public RESTTokenManager()
        {
            ClientTokenId = 0;
            _environment = SetRESTAllegroEnvironment();
            if (_accountTokens == null) _accountTokens = new List<AccountToken>();
        }
        public string GetApplicationToken()
        {
            if (_appicationToken == null) _appicationToken = LoadApplicationtoken();
            if (DateTime.Compare(_appicationToken.TokenTime, DateTime.Now) <= 0)
            {
                _appicationToken = null;
                return GetApplicationToken();
            }
            return "Bearer " + _appicationToken.TokenRest;
        }

        public string GetBasePath()
        {
            return _environment == RESTAllegroEnvironment.Product ? "https://api.allegro.pl" : "https://api.allegro.pl.allegrosandbox.pl";
        }

        public string GetBasePath(ApiType type)
        { 
            if(type == ApiType.Image)
                return _environment == RESTAllegroEnvironment.Product ? "https://upload.allegro.pl" : "https://upload.allegro.pl.allegrosandbox.pl";
            if(type == ApiType.Auth)
                return _environment == RESTAllegroEnvironment.Product ? "https://allegro.pl" : "https://allegro.pl.allegrosandbox.pl";
            return GetBasePath();
        }

        public string GetUserToken()
        {
            if (ClientTokenId == 0) throw new NotImplementedException();
            if (_accountTokens.Where(z => z.AllegroAccountId == ClientTokenId).Count() > 0)
            {
                AccountToken accountToken = _accountTokens.Where(z => z.AllegroAccountId == ClientTokenId).First();
                if (DateTime.Compare(accountToken.TokenTime, DateTime.Now) <= 0)
                {
                    var actualToken = RefreshUserToken(accountToken.AllegroAccountId);
                    accountToken.TokenTime = actualToken.TokenTime;
                    accountToken.TokenRest = actualToken.TokenRest;
                    accountToken.RefreshToken = accountToken.RefreshToken;
                    return GetUserToken();
                }
                else return "Bearer " + accountToken.TokenRest;
            }
            else
            {
                var token = LoadAccountToken(ClientTokenId);
                if (token == null) throw new NotImplementedException();
                _accountTokens.Add(token);
                return GetUserToken();
            }
        }

        /// <summary>
        /// Return ApplicationToken
        /// </summary>
        protected ApplicationToken LoadApplicationtoken()
        {
            var api = new AuthorizationClientCredentialsApi(this);
            var token = api.ApplicationTokenPOST();
            ApplicationToken applicationToken = new ApplicationToken() { TokenRest = token.AccesToken , TokenTime = DateTime.Now.AddSeconds(token.ExpiresIn-500)};
            return applicationToken;
        }
        public string GetBasicToken()
        {
            string idks = GetApiClientId() + ":" + GetApiClientSecret();
            byte[] bajty = Encoding.UTF8.GetBytes(idks);
            return "Basic " + Convert.ToBase64String(bajty);
        }
        public abstract RESTAllegroEnvironment SetRESTAllegroEnvironment();
        protected abstract AccountToken LoadAccountToken(int allegroAccountId);
        protected abstract AccountToken RefreshUserToken(int allegroAccountId);
        public abstract string GetApiClientId();
        protected abstract string GetApiClientSecret();
    }
    public class AccountToken
    {
        public int AllegroAccountId { get; set; }
        public string TokenRest { get; set; }
        public DateTime TokenTime { get; set; }
        public string RefreshToken { get; set; }
    }
    public class ApplicationToken
    {
        public string TokenRest { get; set; }
        public DateTime TokenTime { get; set; }
    }
    public enum RESTAllegroEnvironment
    {
        Sandbox = 0,
        Product = 1
    }
}
