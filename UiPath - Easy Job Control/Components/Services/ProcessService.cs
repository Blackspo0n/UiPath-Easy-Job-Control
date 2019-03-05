using System.Diagnostics;
using System.Threading.Tasks;
using UiPathEJC.Service.Rest.Api;
using UiPathEJC.Service.Rest.Client;
using UiPathEJC.Service.Rest.Model;

namespace UiPathEJC.Components.Services
{
    public class ProcessService
    {
        private readonly AuthorizationService _authorizationService;
        private readonly IJobsApi _jobsApi;

        public ProcessService(AuthorizationService authorizationService)
        {
            _authorizationService = authorizationService;
            _jobsApi = new JobsApi(_authorizationService.ServiceConfiguration);
        }

        public async Task StartProcess(ReleaseDto processToStart)
        {
            var jobResult = await _jobsApi.JobsStartJobsAsync(new StartJobParameters()
            {
                StartInfo = new StartProcessDto(processToStart.Key, StartProcessDto.StrategyEnum.JobsCount)
                {
                    Source = StartProcessDto.SourceEnum.Manual,

                    JobsCount = 1
                }
            });

            Debug.WriteLine(jobResult);
        }

    }
}
