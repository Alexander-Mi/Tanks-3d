using UnityEngine;

namespace TankBattle
{
    public class TankEnemy : TankBase
    {
        [SerializeField]
        private GameObject _bulletPrefab;

        [SerializeField]
        private Transform _bulletStartPosition;      
        public override void Fire()
        {
            var bullet = Instantiate(_bulletPrefab, _bulletStartPosition.position, _bulletStartPosition.rotation);
            var b = bullet.GetComponent<Bullet>();
            //b.Init();
        }

        public override void Move()
        {
            throw new System.NotImplementedException();
        }
    }
}
