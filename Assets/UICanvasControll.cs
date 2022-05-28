using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UICanvasControll : SingletonMonoBehavior<UICanvasControll>
{
    [SerializeField] GameObject[] Canvass;

    private void Start()
    {
        InitCanvass();
    }

    void InitCanvass()
    {
        List<GameObject> NewList = new List<GameObject>();
        foreach (Transform Child in transform)
        {
            NewList.Add(Child.gameObject);
        }
        Canvass = NewList.ToArray();
    }

    public static void CloseAllUIExpectIndex(int Index)
    {
        for (int i = 0; i < instance.Canvass.Length; i++)
        {
            GameObject Item = instance.Canvass[i];
            Item.SetActive((i == Index));
        }
    }
}
