using IPConnectionData.App.View;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace IPConnectionData.App.Services
{
    /// <summary>
    /// Service to Open Windows.
    /// </summary>
    public class DialogueService
    {
        Window addConnectionView = null;
        Window configureConnectionsView = null;
        public void ShowAddConnectionViewDialog()
        {
            addConnectionView = new AddConnectionView();
            addConnectionView.ShowDialog();
        }

        public void CloseAddConnectionViewDetailDialog()
        {
            if (addConnectionView != null)
                addConnectionView.Close();
        }

        public void ShowconfigureConnectionsViewDialog()
        {
            configureConnectionsView = new ConfigureConnectionsView();
            configureConnectionsView.ShowDialog();
        }

        public void CloseconfigureConnectionsViewDialog()
        {
            if (configureConnectionsView != null)
                configureConnectionsView.Close();
        }
    }
}
