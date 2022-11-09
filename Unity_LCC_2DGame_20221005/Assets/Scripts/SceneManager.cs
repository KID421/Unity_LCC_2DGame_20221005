using UnityEngine;
using UnityEngine.UI;

namespace KID
{
    /// <summary>
    /// �����޲z
    /// </summary>
    public class SceneManager : MonoBehaviour
    {
        private Button btnReplay;

        private void Awake()
        {
            btnReplay = GameObject.Find("���s�C��").GetComponent<Button>();
            btnReplay.onClick.AddListener(Replay);
        }

        /// <summary>
        /// ���s�C��
        /// </summary>
        private void Replay()
        {
            string nameCurrent = UnityEngine.SceneManagement.SceneManager.GetActiveScene().name;
            UnityEngine.SceneManagement.SceneManager.LoadScene(nameCurrent);
        }
    }
}
