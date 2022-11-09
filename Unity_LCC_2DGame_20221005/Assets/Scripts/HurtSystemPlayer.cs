using UnityEngine;
using System.Collections;

namespace KID
{
    /// <summary>
    /// ���a���˨t��
    /// </summary>
    public class HurtSystemPlayer : HurtSystem
    {
        private CanvasGroup groupMain;
        private WaitForSeconds fadeInterval = new WaitForSeconds(0.02f);

        private void Awake()
        {
            groupMain = GameObject.Find("�e��").GetComponent<CanvasGroup>();
        }

        protected override void Dead()
        {
            GetComponent<Collider2D>().enabled = false;
            GetComponent<SpriteRenderer>().enabled = false;
            StartCoroutine(FadeIn());
        }

        /// <summary>
        /// �H�J�e���s��
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
