using IPConnectionData.App.Repositry;
using IPConnectionData.App.Utility;
using System.ComponentModel;
using System.Windows.Input;
using Microsoft.Practices.Unity;
using IPConnectionData.Model;

namespace IPConnectionData.App.ViewModel
{
    public class AddConnectionsViewModel : INotifyPropertyChanged
    {
        private IPConnections _newConnection;
        private IConnectionsRepository _connectionrepo;

        public IPConnections NewConnection
        {
            get
            {
                // if(_newConnection != null)
                return _newConnection;
                // return new IPConnections();
            }
            set
            {
                _newConnection = value;
                OnPropertyChanged("NewConnection");
            }
        }

        private void RaisePropertyChanged(string propertyName)
        {
            if (PropertyChanged != null)
                PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
        }

        private void OnPropertyChanged(string propertyName)
        {

            if (PropertyChanged != null)
            {
                PropertyChangedEventArgs args = new PropertyChangedEventArgs(propertyName);
                this.PropertyChanged(this, args);
            }
        }
        public ICommand SaveConnections { get; set; }
        public AddConnectionsViewModel()
        {
            NewConnection = new IPConnections();
            _connectionrepo = ContainerHelper.Container.Resolve<IConnectionsRepository>();
            SaveConnections = new CustomCommand(SaveConnection, CanSaveConnection);
        }
        private bool CanSaveConnection(object obj)
        {
            return true;
        }

        private void SaveConnection(object _newConnection)
        {
            _connectionrepo.AddConnection(NewConnection);

        }

        public event PropertyChangedEventHandler PropertyChanged;
    }
}
