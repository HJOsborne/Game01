using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TurnBasedCombatStateMachine : MonoBehaviour
{
    public enum BattleStates
    {
        START,
        PLAYERCHOICE,
        ENEMYCHOICE,
        LOSE,
        WIN
    }

    private BattleStates CurrentState;


    void Start()
    {
        CurrentState = BattleStates.START;
    }

    void Update()
    {
        Debug.Log(CurrentState);
        switch (CurrentState)
        {
            case (BattleStates.START):
                break;
            case (BattleStates.PLAYERCHOICE):
                break;
            case (BattleStates.ENEMYCHOICE):
                break;
            case (BattleStates.LOSE):
                break;
            case (BattleStates.WIN):
                break;
        }
    }

    void OnGUI()
    {
        if (GUILayout.Button("NEXT STATE"))
        {
            if (CurrentState == BattleStates.START)
            {
                CurrentState = BattleStates.PLAYERCHOICE;
            }
            else if (CurrentState == BattleStates.PLAYERCHOICE)
            {
                CurrentState = BattleStates.ENEMYCHOICE;
            }
            else if (CurrentState == BattleStates.ENEMYCHOICE)
            {
                CurrentState = BattleStates.LOSE;
            }
            else if (CurrentState == BattleStates.LOSE)
            {
                CurrentState = BattleStates.WIN;
            }
            else if (CurrentState == BattleStates.WIN)
            {
                CurrentState = BattleStates.START;
            }
        }
    }
}
