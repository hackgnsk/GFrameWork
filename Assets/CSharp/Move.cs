using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using JFramework;
public class Move : MonoBehaviour
{
    public GameObject Cube;
        
    private void Awake()
    {
        EventManager.AddEventListener(EventName.EventTrigger, EventTrigger); //添加事件
    }

    private void Update()
    {
        
    }
    public void OnBtnClick()
    {
        EventManager.OnEventTrigger(EventName.EventTrigger); //触发事件
    }
    private void EventTrigger() //触发事件调用该方法
    {
        Cube.transform.position += new Vector3(0,1,0);
        Debug.Log("触发事件!,Cube坐标Y+1");
    }
        
    private void OnDestroy()
    {
        EventManager.RemoveEventListener(EventName.EventTrigger, EventTrigger); //移除事件
    }
}
public struct EventName
{
    public const string EventTrigger = "EventTrigger"; //建议定一个事件的常量
}
