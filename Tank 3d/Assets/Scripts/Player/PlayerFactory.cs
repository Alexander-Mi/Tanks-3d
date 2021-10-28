using Assets.Scripts.Model;
using UnityEngine;

namespace Assets.Scripts.Player
{
   public sealed class PlayerFactory : IPlayerFactory
        {
            private readonly IPlayerModel _playerData;

            public PlayerFactory(IPlayerModel playerData)
            {
                _playerData = playerData;
            }

            public Transform CreatePlayer()
            {
                return new GameObject(_playerData.Name).
                    AddSprite(_playerData.Sprite).AddCircleCollider3D().
                    AddCircleCollider3D().AddTrailRenderer().transform;
            }
        }
    
}