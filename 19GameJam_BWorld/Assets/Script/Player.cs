using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    [SerializeField] private LayerMask m_WhatIsGround;
    

    public float Speed = 3f;
    bool floating = true;//ジャンプの判定
    public float flameCount = 3f; //ジャンプ力
    private Animator anim;

    void Start()
    {
        anim = GetComponent<Animator>();
    }
    void FixedUpdate()
    {
        var hori = Input.GetAxisRaw("Horizontal");
        var rb = GetComponent<Rigidbody2D>();
        var vel = rb.velocity;
        vel.x = hori * Speed;
        rb.velocity = vel;
        if (vel.x != 0) { anim.SetBool("Dash", true); }
        else { anim.SetBool("Dash", false); }
    }

    void Update()
    {
        //var foot_pos = new Vector2(transform.position.x, transform.position.y - 0.6f);
        //bool floating = (Physics2D.OverlapPoint(foot_pos, m_WhatIsGround) == null); 

        if (floating && Input.GetKeyDown(KeyCode.Space))//ジャンプ判定がtrueでSpaceを押している間の処理
        {
            var rb = GetComponent<Rigidbody2D>();
            rb.AddForce(new Vector2(0f, flameCount), ForceMode2D.Impulse);//addforceでFlameCount分、上に移動
            floating = false;       //ジャンプ判定をoff
            //flameCount = 0;         //フレームカウントをリセットする。   

            /*
            flameCount = flameCount + 20 * Time.deltaTime;//押している間flameCountが増える
            //Debug.Log(flameCount);
            if (flameCount >= 4.6f)
            {
                flameCount = 4.5f;//ジャンプ力の上限
            }*/
        }
        /*
        if (Input.GetKeyUp(KeyCode.Space))//Spaceを離した時の処理
        {
            var rb = GetComponent<Rigidbody2D>();
            rb.AddForce(new Vector2(0f, flameCount), ForceMode2D.Impulse);//addforceでFlameCount分、上に移動
            floating = false;       //ジャンプ判定をoff
            flameCount = 0;         //フレームカウントをリセットする。       
        }*/
    }

    void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("ground") || collision.gameObject.CompareTag("MoveBlock"))
        {
            //Debug.Log(floating);
            floating = true;
        }

        if (collision.gameObject.CompareTag("Damage"))
        {

            // transformを取得
            Transform myTransform = this.transform;

            // リスポーン地点に設定
            Vector2 pos = myTransform.position;
            pos.x = 0;    // x座標
            pos.y = 0;    // y座標

            myTransform.position = pos;  // 座標を設定
        }
    }
  


}
