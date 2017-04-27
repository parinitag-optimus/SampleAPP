using IPConnectionData.App.Repositry;
using IPConnectionData.DAL;
using IPConnectionData.Model;
using System;
using System.Collections.Generic;
using System.Windows;

namespace IPConnectionData.App
{
    /// <summary>
    /// Interaction logic for App.xaml
    /// </summary>
    public partial class App : Application
    {
       // private IConnectionsRepository _repo;
        List<IPConnections> ipConnectionData;
        //public App(IConnectionsRepository repo)
        //{
        //    _repo = repo;
        //}
        public void Application_Startup(object sender, StartupEventArgs e)
        {
            IConnectionsRepository repo = new ConnectionsRepository(new DBAccess());
             ipConnectionData = repo.GetAllConnections();

            if (ipConnectionData.Count != 0)
            {
                StartupUri = new Uri("View/ConfigurationToolView.xaml", UriKind.Relative);
            }
            else
                StartupUri = new Uri("View/ConfigureConnectionsView.xaml", UriKind.Relative);
        }
    }
}
        
    

