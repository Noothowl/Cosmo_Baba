using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class p_script : MonoBehaviour
{
    //vars
    protected Rigidbody2D rb;
    protected float jump_power = 5.75f;
    protected float deathZoneUP = 5.7f;
    protected float deathZoneBot = -5.4f;


    public bool alive = true;
    public Logic_script logic;
    


    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        logic = GameObject.FindGameObjectWithTag("Logic").GetComponent<Logic_script>();
    }

    // Update is called once per frame
    void Update()
    {   
        //if (Input.GetKeyDown(KeyCode.Space) == true && alive == true)
        if (Input.GetKeyDown(KeyCode.Space) && alive)
        {
            Jump();
        }

        if (transform.position.y > deathZoneUP || transform.position.y < deathZoneBot)
        {
            logic.GameOver();
        }


    }

    //methods
    protected void Jump() {
        rb.velocity = Vector2.up * jump_power;
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {   
        alive = false;
        logic.GameOver();

    }



}
