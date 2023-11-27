using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameController : MonoBehaviour
{
    public int turn = 0;
    private bool playerTurn = false;


    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void nextTurn()
    {
        this.turn++;
    }

    public int getTurn()
    {
        return this.turn;
    }

    public bool isPlayerTurn()
    {
        return playerTurn;
    }
}

/*
 *     private float timer;
 *     private bool isDown = false;
if (Input.GetKeyDown(KeyCode.A))
        {
            Debug.Log("Detect Keydown");
            isDown = true;
        }

        if (isDown)
        {
            timer += Time.deltaTime;
            print(timer);
        }

        if (Input.GetKeyUp(KeyCode.A) && isDown)
        {
            if (timer >= 3)
            {
                Debug.Log("3 Seconds");
            }
            else
            {
                Debug.Log("Not for too long");
            }

            timer = 0;
            isDown = false;
        }
*/
