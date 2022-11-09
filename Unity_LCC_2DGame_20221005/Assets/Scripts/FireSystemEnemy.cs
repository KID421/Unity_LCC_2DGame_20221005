using UnityEngine;

namespace KID
{
    /// <summary>
    /// 發射系統：敵人
    /// </summary>
    public class FireSystemEnemy : FireSystemBase
    {
        [SerializeField, Header("發射間隔"), Range(0, 5)]
        private float intervalShoot = 1f;

        private void Awake()
        {

        }

        // 當渲染物件進入攝影機 (Scene、Game) 時執行一次 (Renderer - Sprite Renderer、Mesh Renderer)
        private void OnBecameVisible()
        {
            // Invoke("呼叫方法"，延遲呼叫時間)
            // InvokeRepeating("呼叫方法"，延遲呼叫時間，重複呼叫頻率)
            InvokeRepeating("Fire", 0, intervalShoot);
        }
    }
}
