using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class GameResultUIView : SingletonMonoBehavior<GameResultUIView>
{
    [SerializeField] GameObject LeftUI;
    [SerializeField] GameObject RightUI;

    [SerializeField] RectTransform WinText;
    [SerializeField] RectTransform LoseText;

    public void ShowResult()
    {
        if (GameoverListener.instance.IsLeftSideWin)
        {
            WinText.SetParent(LeftUI.transform);
            LoseText.SetParent(RightUI.transform);

            RectTransformExtensions.SetDefault(WinText);
            RectTransformExtensions.SetDefault(LoseText);
        }
        else
        {
            LoseText.SetParent(LeftUI.transform);
            WinText.SetParent(RightUI.transform);

            RectTransformExtensions.SetDefault(WinText);
            RectTransformExtensions.SetDefault(LoseText);
        }
    }

    public void HideResultUI()
    {
        RectTransformExtensions.SetHide(WinText);
        RectTransformExtensions.SetHide(LoseText);
    }
}
