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
    public int floor;

    public int ShowCoins;

    //Shop;
    public float WeaponDmg;

    //Reference to Enemy script;
    public Enemy Data;

    //Show Coin;
    public Text CoinText;
    public int HowCoins;

    //Dmg Mutiplier;
    public int Damage;
    public int DamageScale;
    public int DamageFloor;


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
        gameStatus.currentLevel = 1;
        floor = gameStatus.currentLevel;

        Damage = 10;

        
    }

    // Update is called once per frame
    void Update()
    {
        ShowStatus();

        GetCoin();



        HowCoins = 10 + ShowCoins;
        CoinText.text = HowCoins.ToString();

        DamageScale = Damage * DamageFloor / 2;
    }



    public void status()
    {

        coins = gameStatus.coins += (int)Mathf.Floor(UnityEngine.Random.Range(1.0f, 20.0f) * gameStatus.currentLevel);
        gameStatus.currentLevel++;

    }

    public void GetCoin()
    {
        if (Data.GetCoins == true)
        {
            status();
            floor++;
        }
    }

    public void Shop()
    {

        if (coins >= 10f + ShowCoins)
        {
            gameStatus.coins = gameStatus.coins - HowCoins;
            WeaponDmg = DamageScale;
            coins = coins - HowCoins;
            ShowCoins += 5;
            DamageFloor++;
        }
            
        
        
        
    }
}

