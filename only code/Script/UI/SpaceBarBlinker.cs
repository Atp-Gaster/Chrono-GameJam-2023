using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpaceBarBlinker : MonoBehaviour
{
    public GameObject spacebar;
    private static bool setSpaceActive = false;

    void Update()
    {
        spacebar.SetActive(setSpaceActive);
    }

    public void setSpaceBar(bool setActive)
    {
        setSpaceActive = setActive;
    }
}
