using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HealthbarControll : SingletonMonoBehavior<HealthbarControll>
{
    [SerializeField] Healthbar[] bars;

    public Healthbar GetHealthbar(bool IsLeft)
    {
        return bars[IsLeft ? 0 : 1];
    }

    private void Start()
    {
        foreach (var item in bars)
        {
            item.Start();
        }
    }
}
