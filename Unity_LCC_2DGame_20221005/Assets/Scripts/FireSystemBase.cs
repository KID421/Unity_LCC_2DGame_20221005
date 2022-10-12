using UnityEngine;

namespace KID
{
    /// <summary>
    /// �g���t�ΰ�
    /// </summary>
    public class FireSystemBase : MonoBehaviour
    {
        [SerializeField, Header("�o�g�����T")]
        private GameObject prefabBullet;
        [SerializeField]
        private Vector3 posFirePoint;
        [SerializeField]
        private Vector3 angleBullet;
        [SerializeField]
        private Vector2 v2Force;
        [SerializeField]
        private Color colorBullet;
        [SerializeField]
        private string tagBullet;

        private void OnDrawGizmos()
        {
            Gizmos.color = new Color(1, 0, 0, 0.3f);
            Gizmos.DrawSphere(transform.position +
                transform.TransformDirection(posFirePoint), 0.1f);
        }

        /// <summary>
        /// �o�g�l�u
        /// </summary>
        protected void Fire()
        {
            Vector3 pos = transform.position +
                transform.TransformDirection(posFirePoint);

            // GameObject tempBullet = Instantiate(prefabBullet, pos, Quaternion.Euler(angleBullet));
            // GameObject tempBullet = GameObject.Find("OOO").GetComponent<ObjectPoolBullet>().Get();
            GameObject tempBullet = ObjectPoolBullet.instance.Get();
            tempBullet.transform.position = pos;
            tempBullet.transform.eulerAngles = angleBullet;
            tempBullet.tag = tagBullet;
            tempBullet.GetComponent<ConstantForce2D>().force = v2Force;
            tempBullet.GetComponent<SpriteRenderer>().color = colorBullet;
        }
    }
}
