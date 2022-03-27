using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HurtEnemy : MonoBehaviour
{

    //Declaring Damge Variable
    public float StartDmg;
    public float damageToGive;

    //Linking Weapon Damage;
    public UI dmg;




    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        damageToGive = StartDmg + dmg.WeaponDmg;
    }

    public void Damage()
    {
        GetComponent<Enemy>().HurtEnemy(damageToGive);
    }
}
