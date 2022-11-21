using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using JFramework;
public class Move : MonoBehaviour
{
    public GameObject Cube;
        
    private void Awake()
    {
        EventManager.AddEventListener(EventName.EventTrigger, EventTrigger); //����¼�
    }

    private void Update()
    {
        
    }
    public void OnBtnClick()
    {
        EventManager.OnEventTrigger(EventName.EventTrigger); //�����¼�
    }
    private void EventTrigger() //�����¼����ø÷���
    {
        Cube.transform.position += new Vector3(0,1,0);
        Debug.Log("�����¼�!,Cube����Y+1");
    }
        
    private void OnDestroy()
    {
        EventManager.RemoveEventListener(EventName.EventTrigger, EventTrigger); //�Ƴ��¼�
    }
}
public struct EventName
{
    public const string EventTrigger = "EventTrigger"; //���鶨һ���¼��ĳ���
}
