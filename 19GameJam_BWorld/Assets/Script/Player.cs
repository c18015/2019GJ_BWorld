using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    [SerializeField] private LayerMask m_WhatIsGround; // 追加

    public float Jamp = 10f;
    public float Speed = 3f;
    bool floating = true;

    public bool isGround;

    public float flameCount; //経過フレーム数



    void FixedUpdate()
    {
        var hori = Input.GetAxisRaw("Horizontal");
        var rb = GetComponent<Rigidbody2D>();
        var vel = rb.velocity;
        vel.x = hori * Speed;
        rb.velocity = vel;
    }

    void Update()
    {

        var foot_pos = new Vector2(transform.position.x, transform.position.y - 0.6f);
        //bool floating = (Physics2D.OverlapPoint(foot_pos, m_WhatIsGround) == null); 
        if (floating && Input.GetKey(KeyCode.Space))
        {

            flameCount = flameCount + 50 * Time.deltaTime;
            Debug.Log(flameCount);

            if(flameCount >= 11)
            {
                flameCount = 10;
            }
        }

 

        if (Input.GetKeyUp(KeyCode.Space))
        {

            var rb = GetComponent<Rigidbody2D>();
            rb.AddForce(new Vector2(0f, flameCount), ForceMode2D.Impulse);
            floating = false;

            flameCount = 0; //フレームカウントをリセットする。
            
        }

        void OnTriggerEnter2D(Collision2D col)
        { 

                Debug.Log("OK");
                floating = true; //修正点


            
        }

        if (Input.GetKeyDown(KeyCode.Q))
        {
            floating = true; //修正点
        }

        /*
        var rb = GetComponent<Rigidbody2D>();
        rb.AddForce(new Vector2(0f, Jamp), ForceMode2D.Impulse);
        floating = false;*/

    }

    

    
}
