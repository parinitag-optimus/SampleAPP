using IPConnectionData.App.Repositry;
using IPConnectionData.DAL;
using Microsoft.Practices.Unity;

namespace IPConnectionData.App
{
    /// <summary>
    /// Class To Implement Unity (IOC Container)
    /// </summary>
    public static class ContainerHelper
    {
        private static IUnityContainer _container;
        static ContainerHelper()
        {
            _container = new UnityContainer();

            _container.RegisterType(typeof(IAlarmRepository),typeof(AlarmRepository));
            _container.RegisterType(typeof(IConnectionsRepository), typeof(ConnectionsRepository));
            _container.RegisterType(typeof(IDataAccess), typeof(DBAccess));
        }
        public static IUnityContainer Container
        {
            get { return _container; }
        }
    }
}
    