using UnityEngine;

namespace KID
{
    /// <summary>
    /// ���a�o�g�t�ΡG��J�o�g
    /// </summary>
    public class FireSystemPlayer : FireSystemBase
    {
        private void Update()
        {
            InputToFire();
        }

        /// <summary>
        /// ��J�õo�g�l�u
        /// </summary>
        private void InputToFire()
        {
            if (Input.GetKeyDown(KeyCode.Space)) Fire();
        }
    }
}
