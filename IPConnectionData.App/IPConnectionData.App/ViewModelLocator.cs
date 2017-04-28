using IPConnectionData.App.Repositry;
using IPConnectionData.App.ViewModel;
using Microsoft.Practices.Unity;

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
        public AddConnectionsViewModel AddConnectionsViewModel
        {
            get
            {
                return new AddConnectionsViewModel();

            }
        }

        public ConfigurationToolViewModel ConfigurationToolViewModel
        {
            get
            {
                return new ConfigurationToolViewModel();

            }
            
        }
    }
}
    
