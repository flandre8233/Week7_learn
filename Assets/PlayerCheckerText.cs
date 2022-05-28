using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class PlayerCheckerText : SingletonMonoBehavior<PlayerCheckerText>
{
    [SerializeField] Text text;
    [SerializeField] Animator animator;

    public void UpdatePlayerTextView()
    {
        int NeedNumber = PlayerInputManagerListener.instance.GetPlayerNeedNumber();
        text.text = "need " + NeedNumber + " more players";
        if (NeedNumber <= 0)
        {
            text.text = "Let's go!!";
        }

        animator.enabled = true;
        animator.Play("PlayerCheckerAni" , 0, 0);
    }
}
