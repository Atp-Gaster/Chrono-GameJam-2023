using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MultipleBulletBarController : MonoBehaviour
{
    public GameObject miscBar;
    public GameObject healthBar;

    //Misc Bar
    public void setValueMisc(int value)
    {
        miscBar.GetComponent<BulletBarBehavior>().setValue(value);
    }

    public void setMaxValueMisc(int value)
    {
        miscBar.GetComponent<BulletBarBehavior>().setMaxValue(value);
    }

    public void fillMaxMisc()
    {
        miscBar.GetComponent<BulletBarBehavior>().fillMax();
    }

    public void attemptDecreasingMisc(int value)
    {
        miscBar.GetComponent<BulletBarBehavior>().attemptDecreasing(value);
    }

    public void confirmDecreasingMisc()
    {
        miscBar.GetComponent<BulletBarBehavior>().confirmDecreasing();
    }

    public void revertDecreasingMisc()
    {
        miscBar.GetComponent<BulletBarBehavior>().revertDecreasing();
    }


    //HP Bar
    public void setValueHp(int value)
    {
        healthBar.GetComponent<BulletBarBehavior>().setValue(value);
    }

    public void setMaxValueHp(int value)
    {
        healthBar.GetComponent<BulletBarBehavior>().setMaxValue(value);
    }

    public void fillMaxHp()
    {
        healthBar.GetComponent<BulletBarBehavior>().fillMax();
    }

    public void attemptDecreasingHp(int value)
    {
        healthBar.GetComponent<BulletBarBehavior>().attemptDecreasing(value);
    }

    public void confirmDecreasingHp()
    {
        healthBar.GetComponent<BulletBarBehavior>().confirmDecreasing();
    }

    public void revertDecreasingHp()
    {
        healthBar.GetComponent<BulletBarBehavior>().revertDecreasing();
    }

    public void printValueMisc()
    {
        miscBar.GetComponent<BulletBarBehavior>().printValue();
    }

}
