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

    public bool animTrue;

    //Linking to HealthBar;
    public EnemyHealth healthbar;

    //Refrence to weapon dmg;
    public HurtEnemy dmg;
    public float DamageCounter;

    //Reference to Floor + Coins;
    public bool GetCoins;

    //Animations;
    Animator animator;



    // Start is called before the first frame update
    void Start()
    {
        EnemyCurrentHealth = EnemyMaxHealth;
        HealthUpdate = EnemyMaxHealth * DamageMulti;
        healthbar.setMaxHealth(EnemyMaxHealth);

        DamageCounter = -dmg.damageToGive;


        //Reference to animator;
        animator = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        if (EnemyCurrentHealth <= DamageCounter)
        {
            EnemyCurrentHealth = HealthUpdate;
            healthbar.setMaxHealth(HealthUpdate);
            GetCoins = true;
        }
        else
        {
            GetCoins = false;
        }

        //Animations;
        AttackAnim();
        if(EnemyCurrentHealth == 0)
        {
            animTrue = true;
            DeathAnim();
        }

        if(EnemyCurrentHealth == HealthUpdate)
        {
            animTrue = false;
            DeathAnim();
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

    public void AttackAnim()
    {
        if (Input.GetMouseButtonDown(0))
        {
            animator.SetBool("Attack", true);
        }
        else
        {
            animator.SetBool("Attack", false);
        }
    }

    public void DeathAnim()
    {
        if (animTrue == true)
        {
            animator.SetBool("Death", true);
        }
        else
        {
            animator.SetBool("Death", false);
        }
    }


}
