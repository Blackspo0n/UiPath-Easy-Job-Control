
using System;
using System.Collections;
using System.Collections.Generic;
using UiPathEJC.Service.Rest.Model;
using UiPathEJC.UserInterfaces.Base;

namespace UiPathEJC.UserInterfaces.UserControls.ViewModels
{
    class JobConfigurationViewModel : ViewModelBase
    {
        #region Binding

        private List<ReleaseDto> _processList;

        public List<ReleaseDto> ProcessList
        {
            get => _processList;
            set
            {
                _processList = value;
                OnPropertyChanged();
            }
        }

        private ReleaseDto _selectedReleaseDto;

        public ReleaseDto SelectedReleaseDto
        {
            get => _selectedReleaseDto;
            set
            {
                _selectedReleaseDto = value;
                OnPropertyChanged();
            }
        }
        
        #endregion

        private JobConfigurationViewModel()
        {

        }

        public JobConfigurationViewModel(List<ReleaseDto> processList)
        {
            ProcessList = processList;
        }

    }
}