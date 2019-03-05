using System;
using System.Diagnostics;
using System.Threading;
using System.Threading.Tasks;
using UiPathEJC.Components.Settings;
using UiPathEJC.Service.Rest.Model;

namespace UiPathEJC.Components.Services
{
    class HeartbeatService
    {

        private readonly Timer _heartBeatTimer;
        private readonly AuthorizationService _authorizationService;
        private bool _lastRequestSuccess;
        public event Action OnHeartBeatFaulted;


        public HeartbeatService(AuthorizationService authorizationService)
        {

            _authorizationService = authorizationService;

            _heartBeatTimer = new Timer(OnHeartBeat, null, 5000, 30000);
        }

        public Task<object> Stop()
        {
            Debug.WriteLine("Stopping Heartbeat Servce");
            _heartBeatTimer?.Change(Timeout.Infinite, Timeout.Infinite);
            return null;

        }

        private async void OnHeartBeat(object state)
        {
            try
            {
                Debug.WriteLine($"Heartbeat Service - Validate Login ...");
                _lastRequestSuccess = await _authorizationService.CanBearerTokenUsed(_authorizationService.CurrentBearerToken);

                if (!_lastRequestSuccess)
                {
                    Debug.WriteLine($"Heartbeat Service - Bearer become invalid. Reauth ...");
                    var settings = new ApplicationSettings();

                    _lastRequestSuccess =
                        await _authorizationService.Authorization(new LoginModel(settings.Tenant, settings.UserName,
                            settings.Password));
                }
                Debug.WriteLine($"Heartbeat Service - Login is ok!");
            }
            catch (Exception e)
            {
                _lastRequestSuccess = false;
            }

            if (!_lastRequestSuccess)
            {
                Debug.WriteLine($"Heartbeat Service - BHeartbeat faulted ...");
                OnHeartBeatFaulted?.Invoke();
            }
            
        }
        
    }
}