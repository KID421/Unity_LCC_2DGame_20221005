using UnityEngine;
using UnityEngine.Pool;

namespace KID
{
    /// <summary>
    /// 物件池基底
    /// </summary>
    public class ObjectPoolBase : MonoBehaviour
    {
        [SerializeField, Header("物件池的物件")]
        private GameObject prefabObject;
        [SerializeField, Header("物件池最大數量"), Range(0, 300)]
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
        /// 建立物件池時執行
        /// Func 傳回並無參數
        /// </summary>
        private GameObject CreateObjectPool()
        {
            GameObject tempObject = Instantiate(prefabObject);
            tempObject.name = prefabObject + " " + (++index);
            return tempObject;
        }

        /// <summary>
        /// 取得物件池內的物件，跟物件池拿物件時執行一次
        /// Action 無傳回帶參數
        /// </summary>
        /// <param name="objectInPool">獲得的物件</param>
        private void GetObjectInPool(GameObject objectInPool)
        {
            objectInPool.SetActive(true);
        }

        /// <summary>
        /// 將物件還給物件池時執行一次
        /// </summary>
        /// <param name="objectInPool">還回去的物件</param>
        private void ReleaseObjectInPool(GameObject objectInPool)
        {
            objectInPool.SetActive(false);
        }

        /// <summary>
        /// 當數量超出最大值時刪除物件池的物件，超出時執行一次
        /// </summary>
        /// <param name="objectInPool">要刪除的物件</param>
        private void DestroyObjectInPool(GameObject objectInPool)
        {
            Destroy(objectInPool);
        }

        /// <summary>
        /// 測試用
        /// </summary>
        private void Test()
        {
            if (Input.GetKeyDown(KeyCode.Alpha1)) Get();
            else if (Input.GetKeyDown(KeyCode.Alpha2)) Release(GameObject.FindGameObjectWithTag("子彈"));
        }

        /// <summary>
        /// 取得物件池的物件
        /// </summary>
        public GameObject Get()
        {
            return objectPool.Get();
        }

        /// <summary>
        /// 還給物件池
        /// </summary>
        /// <param name="objectToRelease">要歸還的物件</param>
        public void Release(GameObject objectToRelease)
        {
            objectPool.Release(objectToRelease);
        }
    }
}
