using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AnimationControl : MonoBehaviour
{
    //Declearing variables;
    Animator animator;

    //Reference to Enemy Health;
    public Enemy health;

    // Start is called before the first frame update
    void Start()
    {
        animator = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetMouseButtonDown(0))
        {
            animator.SetBool("Attack", true);
        }
        else
        {
            animator.SetBool("Attack", false);
        }

        if (health.EnemyCurrentHealth == 0)
        {
            animator.SetBool("Die", true);
        }
        else
        {
            animator.SetBool("Die", false);
        }
    }
}
