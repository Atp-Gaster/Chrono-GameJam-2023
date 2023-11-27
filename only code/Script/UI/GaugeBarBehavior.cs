using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GaugeBarBehavior : MonoBehaviour
{
    public int value;
    private int maxValue = 6;

    public Image[] bullets;
    public Sprite[] fillGauge;
    public Sprite emptyBullet;

    void Start()
    {
        //Initiate Value
        if (value > maxValue)
        {
            value = maxValue;
        }
    }

    void Update()
    {
        //Bullet Changer
        for (int i = 0; i < bullets.Length; i++)
        {
            if (value > maxValue)
            {
                value = maxValue;
            }

            if (i < value)
            {
                bullets[i].sprite = fillGauge[i];
            }
            else
            {
                bullets[i].sprite = emptyBullet;
            }

            if (i < maxValue)
            {
                bullets[i].enabled = true;
            }
            else
            {
                bullets[i].enabled = false;
            }
        }
    }

    //Implementable Methods
    public void setValue(int value)
    {
        this.value = value;
    }

    public void setMaxValue(int value)
    {
        this.maxValue = value;
    }

    public void fillMax()
    {
        value = maxValue;
    }
}