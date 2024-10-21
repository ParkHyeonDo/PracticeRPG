using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class QuestManager : MonoBehaviour
{
    // [�������� 1] ���� �ʵ� ����
    private static QuestManager instance;

    // [�������� 2] ���� ������Ƽ ����
    public static QuestManager Instance
    {
        get
        {
            if (instance == null)
            {
                instance = GameObject.FindObjectOfType<QuestManager>();
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
}
