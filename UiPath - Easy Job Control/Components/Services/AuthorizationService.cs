using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Threading.Tasks;
using UiPathEJC.Service.Rest.Api;
using UiPathEJC.Service.Rest.Client;
using UiPathEJC.Service.Rest.Model;

namespace UiPathEJC.Components.Services
{
    public class AuthorizationService
    {
        private IAccountApi AccountApi { get; set; }

        public string AuthorizationPrefix { get; private set; }

        public string CurrentBearerToken => ServiceConfiguration.ApiKey["Authorization"];

        public Configuration ServiceConfiguration { get; private set; }
    
        public AuthorizationService(Configuration apiConfiguration, String authorizationPrefix)
        {
            AuthorizationPrefix = authorizationPrefix;
            ServiceConfiguration = apiConfiguration;
            ServiceConfiguration.AddApiKeyPrefix("Authorization", "Bearer");

            AccountApi = new AccountApi(apiConfiguration);
        }

        public async Task<bool> Authorization(LoginModel loginModel)
        {
            try
            {
                var result = await AccountApi.AccountAuthenticateAsync(loginModel);
                
                ServiceConfiguration.AddApiKey("Authorization",result.Result.ToString());

                Debug.WriteLine(result.Result.ToString());
                return true;

            }
            catch (Exception e)
            {
                return false;
            }

        }

        public async Task<bool> StillAuthenticated()
        {
            if (!String.IsNullOrWhiteSpace(CurrentBearerToken))
            {
                return await CanBearerTokenUsed(CurrentBearerToken);
            }

            return false;
        }

        public async Task<bool> CanBearerTokenUsed(string bearerToken)
        {
            var tmpConfiguration = new Configuration
            {
                BasePath = AccountApi.Configuration.BasePath
                //DefaultHeader = {["Authorization"] = string.Concat(AuthorizationPrefix, bearerToken)},

            };
            tmpConfiguration.AddApiKeyPrefix("Authorization", "Bearer");
            tmpConfiguration.AddApiKey("Authorization", bearerToken);
            
            var testApi = new UsersApi(tmpConfiguration);

            try
            {
                var test = await testApi.UsersGetCurrentUserAsync();
                return test != null;
            }
            catch (Exception)
            {
                return false;
            }    
        }

        public async Task UseBearerToken(string bearerToken)
        {
            ServiceConfiguration.AddApiKey("Authorization", bearerToken);
        } 
    }
}