using Zenject;

namespace Game.Scripts.Initializers
{
    public class GameSignalsInstaller : Installer<GameSignalsInstaller>
    {
        public override void InstallBindings()
        {
            SignalBusInstaller.Install(Container);

            // Container.DeclareSignal<SpamStatusChangedSignal>().OptionalSubscriber();
        }
    }
}