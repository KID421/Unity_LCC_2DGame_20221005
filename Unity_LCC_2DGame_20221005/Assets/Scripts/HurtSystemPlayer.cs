using UnityEngine;
using System.Collections;

namespace KID
{
    /// <summary>
    /// 玩家受傷系統
    /// </summary>
    public class HurtSystemPlayer : HurtSystem
    {
        private CanvasGroup groupMain;
        private WaitForSeconds fadeInterval = new WaitForSeconds(0.02f);

        private void Awake()
        {
            groupMain = GameObject.Find("畫布").GetComponent<CanvasGroup>();
        }

        protected override void Dead()
        {
            GetComponent<Collider2D>().enabled = false;
            GetComponent<SpriteRenderer>().enabled = false;
            StartCoroutine(FadeIn());
        }

        /// <summary>
        /// 淡入畫布群組
        /// </summary>
        private IEnumerator FadeIn()
        {
            for (int i = 0; i < 10; i++)
            {
                groupMain.alpha += 0.1f;
                yield return fadeInterval;
            }

            groupMain.interactable = true;
            groupMain.blocksRaycasts = true;
        }
    }
}
