using Game.Scripts.Player;
using Game.Scripts.Views;
using UnityEngine;

namespace Game.Scripts.Settings
{
     [CreateAssetMenu(fileName = nameof(PrefabSettings), menuName = nameof(PrefabSettings))]
     public class PrefabSettings : ScriptableObject
     {
          public PlayerMovement playerMovement;
          public GameView GameView;
          public MainMenuUIView MainMenuUIView;
     }
}