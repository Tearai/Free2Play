using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawn : MonoBehaviour
{
    public GameObject Enemy1;
 
    //spawn location;
    public float x = -0.2200012f;
    public float y = -2.218994f;
    public float z = 5.83f;


    // Start is called before the first frame update
    void Start()
    {
        GameObject go = Instantiate(Enemy1, new Vector3 (x, y, z), Quaternion.identity);
        go.transform.parent = GameObject.Find("Spawner").transform;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
