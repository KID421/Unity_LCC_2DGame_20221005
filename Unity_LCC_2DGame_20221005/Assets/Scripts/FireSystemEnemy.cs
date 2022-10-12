using UnityEngine;

namespace KID
{
    /// <summary>
    /// �o�g�t�ΡG�ĤH
    /// </summary>
    public class FireSystemEnemy : FireSystemBase
    {
        [SerializeField, Header("�o�g���j"), Range(0, 5)]
        private float intervalShoot = 1f;

        private void Awake()
        {
            // Invoke("�I�s��k"�A����I�s�ɶ�)
            // InvokeRepeating("�I�s��k"�A����I�s�ɶ��A���ƩI�s�W�v)
            InvokeRepeating("Fire", 0, intervalShoot);
        }
    }
}
