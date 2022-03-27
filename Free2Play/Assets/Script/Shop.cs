using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shop : MonoBehaviour
{
    //Reference to scripts;
    public int CheckCoins;

    //Referencing variables;
    public int Money;
    public float CheckDamage;

    // Start is called before the first frame update
    void Start()
    {
        Money = CheckCoins;

    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void buyWeapons()
    {
        if(gameObject.tag == "Items" && Money == 100)
        {
            CheckDamage = 10;
        }
    }
}
