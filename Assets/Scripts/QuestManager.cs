using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class QuestManager : MonoBehaviour
{
    // [구현사항 1] 정적 필드 정의
    private static QuestManager instance;
    public List<QuestDataSO> questList =  new List<QuestDataSO>();

    // [구현사항 2] 정적 프로퍼티 정의
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

    // [구현사항 3] 인스턴스 검사 로직
    private void Awake()
    {
        if(instance != null) { Destroy(instance); }
        instance = this;

    }

    private void Start()
    {
        foreach (var quest in questList) 
        {
            Debug.Log($"{quest.QuestName} (최소 레벨 :  {quest.QuestRequiredLevel})");
           
        }
        
    }

}
