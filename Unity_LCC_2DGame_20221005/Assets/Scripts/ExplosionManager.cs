using UnityEngine;

namespace KID
{
    /// <summary>
    /// 爆炸管理
    /// </summary>
    public class ExplosionManager : MonoBehaviour
    {
        [SerializeField, Header("爆炸時間"), Range(0, 1.5f)]
        private float timeExplosion = 0.5f;

        private void Awake()
        {
            // 延遲呼叫(方法名稱，延遲時間)
            Invoke("EndToObjectPool", timeExplosion);
        }

        /// <summary>
        /// 結束並回收到物件池
        /// </summary>
        private void EndToObjectPool()
        {
            ObjectPoolExplosion.instance.Release(gameObject);
        }
    }
}
