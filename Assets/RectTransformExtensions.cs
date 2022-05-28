using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public static class RectTransformExtensions
{
    public static void SetDefault(RectTransform rt)
    {
        SetLeft(rt, 0);
        SetRight(rt, 0);
        SetTop(rt, 0);
        SetBottom(rt, 0);
    }

    public static void SetHide(RectTransform rt)
    {
        SetLeft(rt, 20000);
        SetRight(rt, 20000);
        SetTop(rt, 20000);
        SetBottom(rt, 20000);
    }

    public static void SetLeft(this RectTransform rt, float left)
    {
        rt.offsetMin = new Vector2(left, rt.offsetMin.y);
    }

    public static void SetRight(this RectTransform rt, float right)
    {
        rt.offsetMax = new Vector2(-right, rt.offsetMax.y);
    }

    public static void SetTop(this RectTransform rt, float top)
    {
        rt.offsetMax = new Vector2(rt.offsetMax.x, -top);
    }

    public static void SetBottom(this RectTransform rt, float bottom)
    {
        rt.offsetMin = new Vector2(rt.offsetMin.x, bottom);
    }
}