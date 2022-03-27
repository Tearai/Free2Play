using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UI : MonoBehaviour
{

    //Declaring variables;
    public int coins;
    GameStatus gameStatus;
    public bool Get;

    //Shop;
    public float WeaponDmg;

    //Reference to Enemy script;
    public Enemy Data;



    void ShowStatus()
    {
        string message = "";
        //message += "Player Name: " + gameStatus.playerName + "\n";
        message += "Floor: " + gameStatus.currentLevel + "\n";
        message += "Coins: " + gameStatus.coins + "\n";

        GetComponent<Text>().text = message;
    }

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        ShowStatus();

        GetCoin();



    }



    public void status()
    {

        coins = gameStatus.coins += (int)Mathf.Floor(UnityEngine.Random.Range(1.0f, 20.0f));
        gameStatus.currentLevel++;

    }

    public void GetCoin()
    {
        if (Data.GetCoins == true)
        {
            status();
        }
    }

    public void Shop()
    {

        
            WeaponDmg = 10;
        
    }
}
