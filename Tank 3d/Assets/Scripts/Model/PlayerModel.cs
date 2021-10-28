using System;
using UnityEngine;

namespace Assets.Scripts.Model
{
    public class PlayerModel:IPlayerModel
    {
        public Sprite Sprite { get; }
        public float Speed { get; }
        public Vector3Int   Position { get; }
        public String Name { get; }

        public PlayerModel(Sprite sprite, float speed, Vector3Int position, String name)
        {
            Sprite = sprite;
            Speed = speed;
            Position = position;
            Name = name;
        }
    }
}