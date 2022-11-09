using UnityEngine;

namespace KID
{
    /// <summary>
    /// �z���޲z
    /// </summary>
    public class ExplosionManager : MonoBehaviour
    {
        [SerializeField, Header("�z���ɶ�"), Range(0, 1.5f)]
        private float timeExplosion = 0.5f;

        private void Awake()
        {
            // ����I�s(��k�W�١A����ɶ�)
            Invoke("EndToObjectPool", timeExplosion);
        }

        /// <summary>
        /// �����æ^���쪫���
        /// </summary>
        private void EndToObjectPool()
        {
            ObjectPoolExplosion.instance.Release(gameObject);
        }
    }
}
