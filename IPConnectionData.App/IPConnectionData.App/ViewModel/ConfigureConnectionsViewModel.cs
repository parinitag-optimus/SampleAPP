using IPConnectionData.App.Services;
using IPConnectionData.App.Utility;
using System.ComponentModel;
using System.Windows.Input;
using IPConnectionData.App.Repositry;
using IPConnectionData.Model;
using System.Collections.Generic;
using Microsoft.Practices.Unity;

namespace IPConnectionData.App.ViewModel
{
    public class ConfigureConnectionsViewModel : INotifyPropertyChanged
    {
        private IConnectionsRepository _connectionsrepo;
        private List<IPConnections> _connections;
        private DialogueService _dialogueService;
        public ICommand AddIPConnections { get; set; }

        public List<IPConnections> Connections
        {
            get
            {
                return _connections;
            }
            set
            {
                _connections = value;
                OnPropertyChanged("Alarms");
            }
        }
        public ConfigureConnectionsViewModel()
        {
            _connectionsrepo = ContainerHelper.Container.Resolve<IConnectionsRepository>();
            LoadIPConnections();
            AddIPConnections = new CustomCommand(AddCommand, CanAddCommand);
           
        }

        private void LoadIPConnections()
        {                     
            Connections = _connectionsrepo.GetAllConnections();
        }

        private bool CanAddCommand(object obj)
        {
            return true;
        }

        private void AddCommand(object coffee)
        {
            //_repo.AddConnection();
            _dialogueService = new DialogueService();
            _dialogueService.ShowAddConnectionViewDialog();
        }


        private void OnPropertyChanged(string propertyName)
        {

            if (PropertyChanged != null)
            {
                PropertyChangedEventArgs args = new PropertyChangedEventArgs(propertyName);
                this.PropertyChanged(this, args);
            }
        }
        public event PropertyChangedEventHandler PropertyChanged;
    }
}
