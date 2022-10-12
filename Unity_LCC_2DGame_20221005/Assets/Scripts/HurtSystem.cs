using UnityEngine;

namespace KID
{
    /// <summary>
    /// ���˨t��
    /// </summary>
    public class HurtSystem : MonoBehaviour
    {
        [SerializeField, Header("�I��|���ˮ`������")]
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
        /// ���˫ᦺ�`�åB�ͦ��z���S��
        /// </summary>
        /// <param name="tag">�I�����������</param>
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
