using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class pipe_movement_script : MonoBehaviour
{
    protected float movement_speed = 5;
    protected float deathZone = -10;
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {           
        Move();
    }

    //mtds
    void Move()
    {   
        transform.position = transform.position+(Vector3.left*movement_speed*Time.deltaTime);

        if (transform.position.x < deathZone)
        {
            Destroy(gameObject);
            Debug.Log("Destroyed");
        }
    }

    

}
