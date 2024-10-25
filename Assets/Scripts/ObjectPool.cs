using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnityEditor;
using UnityEngine;

public class ObjectPool : MonoBehaviour
{
    public GameObject prefab;
    private List<GameObject> pool;
    public int poolSize = 300;
    public Dictionary <string , List<GameObject>> dictionary = new Dictionary<string , List<GameObject>>();
    [SerializeField]private string objectName;

    void Start()
    {
        pool = new List<GameObject>(poolSize);
        // 미리 poolSize만큼 게임오브젝트를 생성한다.
        for (int i = 0; i < poolSize; i++) 
        {
            GameObject obj = Instantiate(prefab, transform);
            obj.name = objectName;
            //pool.Add(obj);
            dictionary.Add(obj.name, pool);
        }

        
    }

    public GameObject Get()
    {
        if (dictionary.ContainsKey(objectName)) 
        {
            foreach (GameObject obj in pool)
            {
                if (!obj.activeInHierarchy)
                {
                    obj.SetActive(true);
                    return obj;

                }
            }

        }// 꺼져있는 게임오브젝트를 찾아 active한 상태로 변경하고 return 한다.
        return null;
    }

    public void Release(GameObject obj)
    {
        obj.SetActive(false);
        // 게임오브젝트를 deactive한다. 
    }
}
