using UnityEngine;

namespace KID
{
    /// <summary>
    /// 玩家發射系統：輸入發射
    /// </summary>
    public class FireSystemPlayer : FireSystemBase
    {
        private void Update()
        {
            InputToFire();
        }

        /// <summary>
        /// 輸入並發射子彈
        /// </summary>
        private void InputToFire()
        {
            if (Input.GetKeyDown(KeyCode.Space)) Fire();
        }
    }
}
