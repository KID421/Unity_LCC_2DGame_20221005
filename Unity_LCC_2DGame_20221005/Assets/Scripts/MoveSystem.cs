using UnityEngine;

namespace KID
{
    /// <summary>
    /// 移動系統
    /// </summary>
    public class MoveSystem : MonoBehaviour
    {
        [SerializeField, Header("移動速度"), Range(0, 50)]
        private float speed = 3.5f;

        private void Update()
        {
            Move();
        }

        /// <summary>
        /// 移動
        /// </summary>
        private void Move()
        {
            transform.Translate(-speed * Time.deltaTime, 0, 0);
        }
    }
}
