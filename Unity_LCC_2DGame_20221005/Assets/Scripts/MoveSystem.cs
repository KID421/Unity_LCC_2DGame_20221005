using UnityEngine;

namespace KID
{
    /// <summary>
    /// ���ʨt��
    /// </summary>
    public class MoveSystem : MonoBehaviour
    {
        [SerializeField, Header("���ʳt��"), Range(0, 50)]
        private float speed = 3.5f;

        private void Update()
        {
            Move();
        }

        /// <summary>
        /// ����
        /// </summary>
        private void Move()
        {
            transform.Translate(-speed * Time.deltaTime, 0, 0);
        }
    }
}
