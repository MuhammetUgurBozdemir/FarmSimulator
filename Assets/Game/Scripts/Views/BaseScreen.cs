using UnityEngine;
using Zenject;

namespace Game.Scripts.Views
{
    public class BaseScreen : BaseView
    {
        public override void Initialize()
        {
			
        }

        public override void Dispose()
        {
            
        }

        public class Factory : PlaceholderFactory<Object, BaseScreen> {}

    }
}