using UnityEngine;
using UnityEngine.Pool;

namespace KID
{
    /// <summary>
    /// �������
    /// </summary>
    public class ObjectPoolBase : MonoBehaviour
    {
        [SerializeField, Header("�����������")]
        private GameObject prefabObject;
        [SerializeField, Header("������̤j�ƶq"), Range(0, 300)]
        private int countMax = 100;

        private ObjectPool<GameObject> objectPool;
        private int index;

        private void Awake()
        {
            objectPool = new ObjectPool<GameObject>(CreateObjectPool, GetObjectInPool, ReleaseObjectInPool, DestroyObjectInPool, maxSize: countMax);
        }

        private void Update()
        {
            Test();
        }

        /// <summary>
        /// �إߪ�����ɰ���
        /// Func �Ǧ^�õL�Ѽ�
        /// </summary>
        private GameObject CreateObjectPool()
        {
            GameObject tempObject = Instantiate(prefabObject);
            tempObject.name = prefabObject + " " + (++index);
            return tempObject;
        }

        /// <summary>
        /// ���o�������������A�򪫥��������ɰ���@��
        /// Action �L�Ǧ^�a�Ѽ�
        /// </summary>
        /// <param name="objectInPool">��o������</param>
        private void GetObjectInPool(GameObject objectInPool)
        {
            objectInPool.SetActive(true);
        }

        /// <summary>
        /// �N�����ٵ�������ɰ���@��
        /// </summary>
        /// <param name="objectInPool">�٦^�h������</param>
        private void ReleaseObjectInPool(GameObject objectInPool)
        {
            objectInPool.SetActive(false);
        }

        /// <summary>
        /// ��ƶq�W�X�̤j�ȮɧR�������������A�W�X�ɰ���@��
        /// </summary>
        /// <param name="objectInPool">�n�R��������</param>
        private void DestroyObjectInPool(GameObject objectInPool)
        {
            Destroy(objectInPool);
        }

        /// <summary>
        /// ���ե�
        /// </summary>
        private void Test()
        {
            if (Input.GetKeyDown(KeyCode.Alpha1)) Get();
            else if (Input.GetKeyDown(KeyCode.Alpha2)) Release(GameObject.FindGameObjectWithTag("�l�u"));
        }

        /// <summary>
        /// ���o�����������
        /// </summary>
        public GameObject Get()
        {
            return objectPool.Get();
        }

        /// <summary>
        /// �ٵ������
        /// </summary>
        /// <param name="objectToRelease">�n�k�٪�����</param>
        public void Release(GameObject objectToRelease)
        {
            objectPool.Release(objectToRelease);
        }
    }
}
