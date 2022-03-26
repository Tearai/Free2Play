using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HurtEnemy : MonoBehaviour
{

    //Declaring Damge Variable
    public float damageToGive; 




    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void Damage()
    {
        GetComponent<Enemy>().HurtEnemy(damageToGive);
    }
}
