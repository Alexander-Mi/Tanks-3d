using System;
using UnityEngine;

namespace Assets.Scripts.Model
{
    public interface IPlayerModel
    {
        public Sprite Sprite { get; }
        public float Speed { get; }
        public Vector3Int   Position { get; }
        public String Name { get; }
    }
}