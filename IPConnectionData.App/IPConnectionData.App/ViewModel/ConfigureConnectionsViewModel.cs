using IPConnectionData.App.Services;
using IPConnectionData.App.Utility;
using System.ComponentModel;
using System.Windows.Input;

namespace IPConnectionData.App.ViewModel
{
    public class ConfigureConnectionsViewModel : INotifyPropertyChanged
    {
        //private IConnectionsRepository _repo;
        private DialogueService _dialogueService;
        public ICommand AddConnections { get; set; }
        public ConfigureConnectionsViewModel()
        {
           
            AddConnections = new CustomCommand(AddCommand, CanAddCommand);
           
        }
        private bool CanAddCommand(object obj)
        {
            return true;
        }

        private void AddCommand(object coffee)
        {
            //_repo.AddConnection();
            _dialogueService = new DialogueService();
            _dialogueService.ShowDetailDialog();
        }
        public event PropertyChangedEventHandler PropertyChanged;
    }
}
