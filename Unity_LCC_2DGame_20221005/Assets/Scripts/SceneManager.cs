using UnityEngine;
using UnityEngine.UI;

namespace KID
{
    /// <summary>
    /// 場景管理
    /// </summary>
    public class SceneManager : MonoBehaviour
    {
        private Button btnReplay;

        private void Awake()
        {
            btnReplay = GameObject.Find("重新遊戲").GetComponent<Button>();
            btnReplay.onClick.AddListener(Replay);
        }

        /// <summary>
        /// 重新遊戲
        /// </summary>
        private void Replay()
        {
            string nameCurrent = UnityEngine.SceneManagement.SceneManager.GetActiveScene().name;
            UnityEngine.SceneManagement.SceneManager.LoadScene(nameCurrent);
        }
    }
}
