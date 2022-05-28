using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Nitrogen : MonoBehaviour
{
    [SerializeField] float Max;

    float _Cur;

    float Cur
    {
        get
        {
            return _Cur;
        }
        set
        {
            _Cur = Mathf.Clamp(value, 0, Max);
        }
    }
    [SerializeField] float lossSpeed;
    [SerializeField] float Regenerate;
    public Healthbar BarView;
    // Start is called before the first frame update
    void Start()
    {
        Cur = Max;
    }

    // Update is called once per frame
    void Update()
    {
        Regeneration();
        BarView.SetHealth(GetPercentage() * 100);
    }

    void Regeneration()
    {
        Cur += Time.deltaTime * Regenerate;
    }

    public float Loss(float Ratio)
    {
        float PrevCur = Cur;
        Cur -= Time.deltaTime * lossSpeed * Ratio;

        return (PrevCur - Cur) / lossSpeed / Time.deltaTime;
    }

    float GetPercentage()
    {
        return Cur / Max;
    }
}
