using UnityEngine;

namespace KID
{
    /// <summary>
    /// ���a��� 2D �Ҧ�
    /// </summary>
    public class PlayerControl2D : MonoBehaviour
    {
        #region ��ơG��� Field - �ܼ�
        [SerializeField, Header("���ʳt��"), Range(0, 50)]
        private float speed = 3.5f;
        [Header("�Ϥ��G�W���U")]
        [SerializeField]
        private Sprite spriteUp;
        [SerializeField]
        private Sprite spriteMiddle;
        [SerializeField]
        private Sprite spriteDown;

        private SpriteRenderer spr;
        private Rigidbody2D rig;
        #endregion

        #region �ƥ�
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

        #region ��k
        /// <summary>
        /// ����
        /// </summary>
        private void Move()
        {
            float h = Input.GetAxis("Horizontal");  // A D �� ��
            float v = Input.GetAxis("Vertical");    // W S �� ��

            rig.velocity = new Vector2(h, v) * speed;

            if (v > 0) spr.sprite = spriteUp;
            else if (v < 0) spr.sprite = spriteDown;
            else spr.sprite = spriteMiddle;
        }
        #endregion
    }
}
