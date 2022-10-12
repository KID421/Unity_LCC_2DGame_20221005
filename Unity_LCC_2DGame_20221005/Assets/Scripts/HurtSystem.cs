using UnityEngine;

namespace KID
{
    /// <summary>
    /// 受傷系統
    /// </summary>
    public class HurtSystem : MonoBehaviour
    {
        [SerializeField, Header("碰到會有傷害的標籤")]
        private string tagToHurt;

        private void OnTriggerEnter2D(Collider2D collision)
        {
            Hurt(collision.tag);
        }

        private void OnCollisionEnter2D(Collision2D collision)
        {
            Hurt(collision.gameObject.tag);
        }

        /// <summary>
        /// 受傷後死亡並且生成爆炸特效
        /// </summary>
        /// <param name="tag">碰撞的物件標籤</param>
        private void Hurt(string tag)
        {
            if (tag.Equals(tagToHurt))
            {
                Destroy(gameObject);
                GameObject tempExplo = ObjectPoolExplosion.instance.Get();
                tempExplo.transform.position = transform.position;
            }
        }
    }
}
