using UnityEngine;

namespace KID
{
    /// <summary>
    /// Ãz¬µª«¥ó¦À
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
