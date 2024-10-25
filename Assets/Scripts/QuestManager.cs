using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class QuestManager : MonoBehaviour
{
    // [�������� 1] ���� �ʵ� ����
    private static QuestManager instance;
    public List<QuestDataSO> questList =  new List<QuestDataSO>();

    // [�������� 2] ���� ������Ƽ ����
    public static QuestManager Instance
    {
        get
        {
            if (instance == null)
            {
                instance = GameObject.FindObjectOfType<QuestManager>();
                if (instance == null)
                {
                    GameObject gameObject = new GameObject();
                    instance = gameObject.AddComponent<QuestManager>();
                }
            }    
            return instance;
        }
        private set { }
    }

    // [�������� 3] �ν��Ͻ� �˻� ����
    private void Awake()
    {
        if(instance != null) { Destroy(instance); }
        instance = this;

    }

    private void Start()
    {
        foreach (var quest in questList) 
        {
            Debug.Log($"{quest.QuestName} (�ּ� ���� :  {quest.QuestRequiredLevel})");
           
        }
        
    }

}
