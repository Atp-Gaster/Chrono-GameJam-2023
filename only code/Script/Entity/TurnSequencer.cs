using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TurnSequencer : MonoBehaviour
{
    private static int turn = 0;
    private static bool PlayerTurn = false;
    private static float delayTimer = 0;
    private static bool turnEndSeq = false;

    // Start is called before the first frame update
    void Start()
    {
        //Initialize Game

        turn = 1;
    }
    
    // Update is called once per frame
    void Update()
    {
        if (turnEndSeq)
        {
            delayTimer += Time.deltaTime;

            if (delayTimer > 0.2)
            {
                if (turn % 2 == 0)
                {
                    //Enemy Turn
                    PlayerTurn = false;
                }
                else
                {
                    //Player Turn
                    PlayerTurn = true;
                }

                turnEndSeq = false;
            }
        }
    }

    public static void triggerTurnEnd()
    {
        turn++;
        turnEndSeq = true;
    }

    public static void turnReset()
    {
        turn = 1;
    }

    public static int getTurnNumber()
    {
        return turn;
    }

    public static int getDisplayTurnNumber()
    {
        return (int)(turn / 2) + 1;
    }

    public static bool isEnemyTurn()
    {
        return !PlayerTurn;
    }

    public static bool isPlayerTurn()
    {
        return PlayerTurn;
    }
}
