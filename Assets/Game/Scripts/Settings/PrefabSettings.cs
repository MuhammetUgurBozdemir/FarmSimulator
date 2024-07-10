using Game.Scripts.Controllers.Player;
using UnityEngine;
using UnityEngine.Serialization;


[CreateAssetMenu(fileName = nameof(PrefabSettings), menuName = nameof(PrefabSettings))]
public class PrefabSettings : ScriptableObject
{
    [FormerlySerializedAs("playerController")] public PlayerMovement playerMovement;
}