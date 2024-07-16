using System;
using UnityEngine;
using Zenject;

namespace Game.Scripts.Views
{
    public abstract class BaseView : MonoBehaviour, IInitializable, IDisposable
    {
        public abstract void Initialize();

        public abstract void Dispose();

        public void DestroyView(float delay = 0)
        {
            Dispose();
            Destroy(gameObject, delay);
        }
		
    }
}