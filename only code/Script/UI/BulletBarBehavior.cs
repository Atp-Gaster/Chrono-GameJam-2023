using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class BulletBarBehavior : MonoBehaviour
{
    public int value;
    public int maxValue;

    private bool isBlinking = false;
    private int decreaseToVal = -1;
    private float timer = 0;

    public Image[] bullets;
    public Sprite fillBullet;
    public Sprite usingBullet;
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
        //Not blink
        if (!isBlinking)
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
                    bullets[i].sprite = fillBullet;
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

        //Blinking
        else
        {
            for (int i = 0; i < bullets.Length; i++)
            {
                if (i < maxValue)
                {
                    bullets[i].enabled = true;
                }
                else
                {
                    bullets[i].enabled = false;
                }
            }

            timer += Time.deltaTime;

            if (Convert.ToInt32(Math.Floor(timer * 10)) % 10 >= 0 && Convert.ToInt32(Math.Floor(timer * 10)) % 10 < 5)
            {
                for (int i = decreaseToVal; i < value; i++)
                {
                    bullets[i].sprite = usingBullet;
                }
            }
            else
            {
                for (int i = decreaseToVal; i < value; i++)
                {
                    bullets[i].sprite = fillBullet;
                }
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

    //Initiate decreasing sequence
    //Set --> how much to decrease --> blink
    public void attemptDecreasing(int value)
    {
        Debug.Log("Blinking");
        if (value >= this.value)
        {
            Debug.Log("You can only set this value to lower than the current value");
            return;
        }

        decreaseToVal = value;
        isBlinking = true;
    }

    //Apply decreasing sequence
    //decrease --> unblink
    public void confirmDecreasing()
    {
        if (!isBlinking || decreaseToVal == -1)
        {
            Debug.Log("Attempt to decrease first");
            return;
        }
        this.value = decreaseToVal;
        isBlinking = false;
        decreaseToVal = -1;
    }

    //Cancel Blinking Sequence
    //Unset --> Return to normal state
    public void revertDecreasing()
    {
        if (!isBlinking || decreaseToVal == -1)
        {
            Debug.Log("Attempt to decrease first");
            return;
        }
        isBlinking = false;
        decreaseToVal = -1;
    }

    public void printValue()
    {
        Debug.Log("Current Value:" + value + ", Current Max: " + maxValue);
    }
}