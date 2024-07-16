using System;
using Zenject;

namespace Game.Scripts.Controllers
{
    public abstract class BaseController : IInitializable, IDisposable
    {
        #region Injection

        protected SignalBus _signalBus;
        
        [Inject]
        private void Construct(SignalBus signalBus)
        {
            _signalBus = signalBus;
        }

        #endregion

        public abstract void Initialize();
        public abstract void Dispose();
    }
}