using UnityEngine;

namespace TankBattle
{
    public class Bullet : MonoBehaviour
    {
        [SerializeField] private float _speed;
       
        private void Update()
        {
            transform.Translate(Vector3.forward * _speed * Time.deltaTime);
        }

        private void OnCollisionEnter(Collision collision)
        {
            TankEnemy tankEnemy = collision.gameObject.GetComponent<TankEnemy>();
            if (tankEnemy != null)
            {
                tankEnemy.Fire();
                Destroy(this.gameObject);
            }            
        }
    }
}