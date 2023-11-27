using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletBarController : MonoBehaviour
{
    public GameObject bulletBar;

    public void setValue(int value)
    {
        bulletBar.GetComponent<BulletBarBehavior>().setValue(value);
    }

    public void setMaxValue(int value)
    {
        bulletBar.GetComponent<BulletBarBehavior>().setMaxValue(value);
    }

    public void fillMax()
    {
        bulletBar.GetComponent<BulletBarBehavior>().fillMax();
    }
}
