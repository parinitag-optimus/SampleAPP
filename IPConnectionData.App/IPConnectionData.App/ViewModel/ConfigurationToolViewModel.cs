using IPConnectionData.App.Repositry;
using IPConnectionData.App.Services;
using IPConnectionData.App.Utility;
using IPConnectionData.Model;
using Microsoft.Practices.Unity;
using System.Collections.Generic;
using System.ComponentModel;
using System.Windows.Input;
using System;

namespace IPConnectionData.App.ViewModel
{
    public class ConfigurationToolViewModel:INotifyPropertyChanged
    {
        private List<Alarms> _alarms;
        private List<JacquesDevices> _devices;
        private IAlarmRepository _alarmsrepo;
        private DialogueService _dialogueService;        
        
        public ICommand AddConnections { get; set; }
        private Alarms _selectedAlarms;
        private JacquesDevices _selectedDevices;

        public ICommand GetAlarmTags { get; set; }
        

        public JacquesDevices SelectedDevices
        {
            get
            {
                return _selectedDevices;
            }
            set
            {
                _selectedDevices = value;
                OnPropertyChanged("SelectedCoffee");
            }
        }



        public Alarms SelectedAlarm
        {
            get
            {
                return _selectedAlarms;
            }
            set
            {
                _selectedAlarms = value;
                OnPropertyChanged("SelectedCoffee");
            }
        }
        public event PropertyChangedEventHandler PropertyChanged;

        public List<Alarms> Alarms
        {
            get
            {
                return _alarms;
            }
            set
            {
                _alarms = value;
                OnPropertyChanged("Alarms");
            }
        }

        public List<JacquesDevices> Devices
        {
            get
            {
                return _devices;
            }
            set
            {
                _devices = value;
                OnPropertyChanged("Devices");
            }
        }

        public ConfigurationToolViewModel()
        {
            SelectedAlarm = new Alarms();
            SelectedDevices = new JacquesDevices();
            _alarmsrepo =ContainerHelper.Container.Resolve<IAlarmRepository>();
            LoadAlarmsData();
            LoadJacquesTagData();
            AddConnections = new CustomCommand(AddConnectionCommand, CanAddConnectionCommand);
            GetAlarmTags = new CustomCommand(GetAlarmTagsCommand, CanGetAlarmTagsCommand);

        }

        private bool CanGetAlarmTagsCommand(object obj)
        {
            return true;
        }

        private void GetAlarmTagsCommand(object obj)
        {
            _alarmsrepo.GetAlarmTags();
        }

        private void LoadJacquesTagData()
        {
            Devices = _alarmsrepo.GetAllJacquesDevices();
        }

        private void LoadAlarmsData()
        {          

            Alarms = _alarmsrepo.GetAllAlarms();             
        }

        private bool CanAddConnectionCommand(object obj)
        {
            return true;
        }

        private void AddConnectionCommand(object coffee)
        {            
            _dialogueService = new DialogueService();
            _dialogueService.ShowconfigureConnectionsViewDialog();
        }

        private void OnPropertyChanged(string propertyName)
        {

            if (PropertyChanged != null)
            {
                PropertyChangedEventArgs args = new PropertyChangedEventArgs(propertyName);
                this.PropertyChanged(this, args);
            }
        }
    }
}
