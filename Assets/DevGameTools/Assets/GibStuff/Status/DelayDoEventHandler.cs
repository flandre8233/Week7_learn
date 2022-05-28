using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public delegate void EventHandler();

public class DelayDoEventHandler : MonoBehaviour
{
    [SerializeField]
    protected float DelayTime;
    protected EventHandler TimeEndHandler;
    [SerializeField] float CurTime;

    public static DelayDoEventHandler Create(EventHandler Event, float Delay)
    {
        GameObject SpawnObject = new GameObject();
        DelayDoEventHandler Delayer = SpawnObject.AddComponent<DelayDoEventHandler>();
        SpawnObject.name = Delayer.GetType().Name;
        Delayer.TimeEndHandler = Event;
        Delayer.DelayTime = Delay;
        return Delayer;
    }

    protected virtual void Update()
    {
        CurTime += Time.deltaTime;
        if (CurTime > DelayTime)
        {
            TryInvokeHandler();
            Disconstruct();
        }
    }

    public void TryInvokeHandler()
    {
        if (TimeEndHandler != null)
        {
            TimeEndHandler();
        }
    }

    public void Disconstruct()
    {
        Destroy(gameObject);
    }
}
