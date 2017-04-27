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
        public void ShowDetailDialog()
        {
            addConnectionView = new AddConnectionView();
            addConnectionView.ShowDialog();
        }

        public void CloseDetailDialog()
        {
            if (addConnectionView != null)
                addConnectionView.Close();
        }
    }
}
