using UnityEngine;

namespace KID
{
    /// <summary>
    /// �l�u�����
    /// </summary>
    public class ObjectPoolBullet : ObjectPoolBase
    {
        public static ObjectPoolBullet instance;

        protected override void Awake()
        {
            base.Awake();

            instance = this;
        }
    }
}
