using IPConnectionData.App.ViewModel;

namespace IPConnectionData.App
{
    /// <summary>
    /// Class For Locating the ViewModels 
    /// </summary>
    public class ViewModelLocator
    {
        public ConfigureConnectionsViewModel ConfigureConnectionsViewModel
        {
            get
            {
                return new ConfigureConnectionsViewModel();

            }
        }
    }
}
    
