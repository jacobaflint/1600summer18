using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameStates : MonoBehaviour
{
    public GameStateBase Starting;
    public GameStateBase Playing;
    public GameStateBase Ending;
    
    public enum States
    {
        Starting,
        Playing,
        Ending
    }

    private void Update()
    {
        ChangeState();
    }

    private States CurrentState;

    public void ChangeState()
    {
        switch (CurrentState)
        {
            case States.Starting:
                Starting.Run();
                break;
            case States.Playing:
                Playing.Run();
                break;
            case States.Ending:
                Ending.Run();
                break;
        }
    }
}
