using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TurnBasedCombatStateMachine : MonoBehaviour
{
    public enum BattleStates
    {
        START,
        PLAYERCHOICE,
        ENEMYCHOICE,
        ACTION,
        LOSE,
        WIN
    }

    public int PlayerTurn;
    public int EnemyTurn;

    public int PlayerSpeed;
    public int EnemySpeed;

    private BattleStates CurrentState;

    public Button AttackBtn;
    public Button MagicBtn;
    public Button FleeBtn;

    void Start()
    {
        CurrentState = BattleStates.START;

        PlayerTurn = 0;
        EnemyTurn = 0;
        PlayerSpeed = GameObject.Find("Char01").GetComponent<UnitStats>().speed;
        EnemySpeed = GameObject.Find("knightprefab").GetComponent<UnitStats>().speed;

        AttackBtn.gameObject.SetActive(false);
        MagicBtn.gameObject.SetActive(false);
        FleeBtn.gameObject.SetActive(false);
        



    }

    public void Attack()
    {
        Debug.Log("Attack success");
        PlayerTurn = 0;
        CurrentState = BattleStates.START;
        StartCoroutine(ThreeSecWait());
        AttackBtn.gameObject.SetActive(false);
        MagicBtn.gameObject.SetActive(false);
        FleeBtn.gameObject.SetActive(false);
    }

    IEnumerator ThreeSecWait()
    {
        print(Time.time);
        yield return new WaitForSeconds(3);
        print(Time.time);
    }

    void Update()
    {
        Debug.Log(CurrentState);
        Debug.Log(PlayerTurn);
        Debug.Log(EnemyTurn);

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

        if (CurrentState == BattleStates.START)
        {
            PlayerTurn = PlayerTurn + PlayerSpeed;
            EnemyTurn = EnemyTurn + EnemySpeed;
        }

        if (PlayerTurn >= 200)
        {
            CurrentState = BattleStates.PLAYERCHOICE;

        }
        if (EnemyTurn >= 200)
        {
            CurrentState = BattleStates.ENEMYCHOICE;
        }

        if (CurrentState == BattleStates.PLAYERCHOICE)
        {
            AttackBtn.gameObject.SetActive(true);
            MagicBtn.gameObject.SetActive(true);
            FleeBtn.gameObject.SetActive(true);
            AttackBtn.onClick.AddListener(Attack);
        }
    }







}
