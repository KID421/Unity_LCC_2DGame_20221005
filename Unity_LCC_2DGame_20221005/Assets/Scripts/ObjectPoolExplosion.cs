using UnityEngine;

namespace KID
{
    /// <summary>
    /// �z�������
    /// </summary>
    public class ObjectPoolExplosion : ObjectPoolBase
    {
        public static ObjectPoolExplosion instance;

        protected override void Awake()
        {
            base.Awake();

            instance = this;
        }
    }
}
