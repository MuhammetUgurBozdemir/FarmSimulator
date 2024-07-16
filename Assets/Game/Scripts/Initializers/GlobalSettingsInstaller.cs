using UnityEngine;
using Zenject;

namespace Game.Scripts.Initializers
{
    [CreateAssetMenu(fileName = nameof(GlobalSettingsInstaller), menuName = nameof(GlobalSettingsInstaller))]
    public class GlobalSettingsInstaller : ScriptableObjectInstaller<GlobalSettingsInstaller>
    {
        [SerializeField]
        private ScriptableObject[] settings;

        public override void InstallBindings()
        {
            foreach (ScriptableObject setting in settings)
            {
                Container.BindInterfacesAndSelfTo(setting.GetType()).FromInstance(setting);
            }
        }
    }
}