using UnityEngine;

namespace Assets.Scripts.Player
{
    public interface IPlayerFactory
    {
        Transform CreatePlayer();
    }
}