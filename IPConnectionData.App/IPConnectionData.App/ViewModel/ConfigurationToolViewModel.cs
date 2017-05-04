using IPConnectionData.App.Repositry;
using IPConnectionData.App.Services;
using IPConnectionData.App.Utility;
using IPConnectionData.Model;
using Microsoft.Practices.Unity;
using System.Collections.Generic;
using System.ComponentModel;
using System.Windows.Input;

namespace IPConnectionData.App.ViewModel
{
    public class ConfigurationToolViewModel:INotifyPropertyChanged
    {
        private List<Alarms> _alarms;
        private List<JacquesDevices> _devices;
        private List<AlarmsTags> _alarmTags;

        private IAlarmRepository _alarmsrepo;
        private DialogueService _dialogueService;     
                
        private Alarms _selectedAlarms;
        private JacquesDevices _selectedDevices;
        private AlarmsTags _selectedAlarmsTags;
       
        public ICommand AddAndGetAlarmTags { get; set; }
        public ICommand AddConnections { get; set; }
        public ICommand RemoveAlarmTags { get; set; }


        public JacquesDevices SelectedDevices
        {
            get
            {
                return _selectedDevices;
            }
            set
            {
                _selectedDevices = value;
                OnPropertyChanged("SelectedDevices");
            }
        }

        public AlarmsTags SelectedAlarmsTags
        {
            get
            {
                return _selectedAlarmsTags;
            }
            set
            {
                _selectedAlarmsTags = value;
                OnPropertyChanged("SelectedAlarmsTags");
            }
        }

        public List<AlarmsTags> AlarmsTags
        {
            get
            {
                return _alarmTags;
            }
            set
            {
                _alarmTags = value;
                OnPropertyChanged("AlarmsTags");
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
                OnPropertyChanged("SelectedAlarm");
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
            SelectedAlarmsTags = new AlarmsTags();
            _alarmsrepo =ContainerHelper.Container.Resolve<IAlarmRepository>();
            LoadAlarmsData();
            LoadJacquesTagData();
            LoadAlarmTagsData();
            AddConnections = new CustomCommand(AddConnectionCommand, CanAddConnectionCommand);
            AddAndGetAlarmTags = new CustomCommand(AddAndGetAlarmTagsCommand, CanAddAndGetAlarmTagsCommand);
            RemoveAlarmTags = new CustomCommand(RemoveAlarmTagsCommand, CanRemoveAlarmTagsCommand);
            //Messenger.Default.Register<UpdateListMessage>(this, OnUpdateListMessageReceived);

        }

        /// <summary>
        /// Method To Remove Alarm Tags
        /// </summary>
        /// <param name="obj"></param>
        /// <returns></returns>
        private bool CanRemoveAlarmTagsCommand(object obj)
        {
            return true;
        }

        private void RemoveAlarmTagsCommand(object obj)
        {
            _alarmsrepo.DeleteAlarmsTags(SelectedAlarmsTags);
            AlarmsTags = _alarmsrepo.GetAlarmTagsList();
            // Messenger.Default.Send<UpdateListMessage>(new UpdateListMessage());
        }

        /// <summary>
        /// Method to Load List of AlarmTags
        /// </summary>
        private void LoadAlarmTagsData()
        {
            AlarmsTags = _alarmsrepo.GetAlarmTagsList();
        }

        private bool CanAddAndGetAlarmTagsCommand(object obj)
        {
            return true;
        }

        /// <summary>
        /// Method to add a new Alarm Tag
        /// </summary>
        /// <param name="obj"></param>
        private void AddAndGetAlarmTagsCommand(object obj)
        {
           // string alarm=
            var values = (object[])obj;
            string alarm = (string)values[0];
            string site = (string)values[1];
            int tagId = (int)values[2];
            AlarmsTags = _alarmsrepo.AddAndGetAlarmTagsList(alarm,site,tagId);
        }

        /// <summary>
        /// Method to Load Jacques Tag Data
        /// </summary>
        private void LoadJacquesTagData()
        {
            Devices = _alarmsrepo.GetAllJacquesDevices();
        }

        /// <summary>
        /// Method To Load Alarms Data
        /// </summary>
        private void LoadAlarmsData()
        {          

            Alarms = _alarmsrepo.GetAllAlarms();             
        }

        /// <summary>
        /// Method to add a new Connection
        /// </summary>
        /// <param name="obj"></param>
        /// <returns></returns>
        private bool CanAddConnectionCommand(object obj)
        {
            return true;
        }

        private void AddConnectionCommand(object connection)
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
