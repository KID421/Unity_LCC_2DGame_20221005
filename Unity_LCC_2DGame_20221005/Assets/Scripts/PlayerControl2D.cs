using UnityEngine;

namespace KID
{
    /// <summary>
    /// 玩家控制器 2D 模式
    /// </summary>
    public class PlayerControl2D : MonoBehaviour
    {
        #region 資料：欄位 Field - 變數
        [SerializeField, Header("移動速度"), Range(0, 50)]
        private float speed = 3.5f;
        [Header("圖片：上中下")]
        [SerializeField]
        private Sprite spriteUp;
        [SerializeField]
        private Sprite spriteMiddle;
        [SerializeField]
        private Sprite spriteDown;

        private SpriteRenderer spr;
        private Rigidbody2D rig;
        #endregion

        #region 事件
        private void Awake()
        {
            spr = GetComponent<SpriteRenderer>();
            rig = GetComponent<Rigidbody2D>();
        }

        private void Update()
        {
            Move();
        }
        #endregion

        #region 方法
        /// <summary>
        /// 移動
        /// </summary>
        private void Move()
        {
            float h = Input.GetAxis("Horizontal");  // A D ← →
            float v = Input.GetAxis("Vertical");    // W S ↑ ↓

            rig.velocity = new Vector2(h, v) * speed;

            if (v > 0) spr.sprite = spriteUp;
            else if (v < 0) spr.sprite = spriteDown;
            else spr.sprite = spriteMiddle;
        }
        #endregion
    }
}
