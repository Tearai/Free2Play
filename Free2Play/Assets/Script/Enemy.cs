using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    //Declearing Enemy Health Variables;
    public float EnemyMaxHealth;
    public float EnemyCurrentHealth;
    public float HealthUpdate;

    public float DamageMulti;

    //Linking to HealthBar;
    public EnemyHealth healthbar;

    //Refrence to weapon dmg;
    public HurtEnemy dmg;
    public float DamageCounter;


    // Start is called before the first frame update
    void Start()
    {
        EnemyCurrentHealth = EnemyMaxHealth;
        HealthUpdate = EnemyMaxHealth * DamageMulti;
        healthbar.setMaxHealth(EnemyMaxHealth);

        DamageCounter = -dmg.damageToGive;
    }

    // Update is called once per frame
    void Update()
    {
        if (EnemyCurrentHealth <= DamageCounter)
        {
            EnemyCurrentHealth = HealthUpdate;
            healthbar.setMaxHealth(HealthUpdate);
        }
    }

    public void HurtEnemy(float damageToGive)
    {
        EnemyCurrentHealth -= damageToGive;
        healthbar.setHealth(EnemyCurrentHealth);
    }

    public void SetMaxHealth()
    {
        EnemyCurrentHealth = EnemyMaxHealth;
    }
}
