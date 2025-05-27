using UnityEngine;

namespace MRX.DefenseGameV1
{
    public class WeaponPlayer : MonoBehaviour
    {
        private void OnTriggerEnter2D(Collider2D colTarget)
        {   if (colTarget == null) return;
            if (colTarget.CompareTag(Const.ENEMY_TAG))
            {
                Enemy enemy = colTarget.GetComponent<Enemy>();
                if (enemy)
                    enemy.Die();
            }
        }
    }

}