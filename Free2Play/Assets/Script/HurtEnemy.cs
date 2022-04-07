using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HurtEnemy : MonoBehaviour
{

    //Declaring Damge Variable
    public float StartDmg;
    public float damageToGive;
    public float showdmg;

    //Linking Weapon Damage;
    public UI dmg;

    //Showing dmg;
    public Text DmgShow;

    public 


    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        showdmg = StartDmg + damageToGive;

        damageToGive = StartDmg + dmg.WeaponDmg;

        DmgShow.text = showdmg.ToString();
    }

    public void Damage()
    {
        GetComponent<Enemy>().HurtEnemy(damageToGive);
    }
}
