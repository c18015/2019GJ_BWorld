using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    [SerializeField] private LayerMask m_WhatIsGround;


    public float Speed = 3f;
    bool floating = true;//ジャンプの判定
    public float flameCount; //ジャンプ力

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

        if (floating && Input.GetKey(KeyCode.Space))//ジャンプ判定がtrueでSpaceを押している間の処理
        {
            flameCount = flameCount + 50 * Time.deltaTime;//押している間flameCountが増える
            //Debug.Log(flameCount);
            if (flameCount >= 11) flameCount = 10;//ジャンプ力の上限
        }

        if (Input.GetKeyUp(KeyCode.Space))//Spaceを離した時の処理
        {
            var rb = GetComponent<Rigidbody2D>();
            rb.AddForce(new Vector2(0f, flameCount), ForceMode2D.Impulse);//addforceでFlameCount分、上に移動
            floating = false;       //ジャンプ判定をoff
            flameCount = 0;         //フレームカウントをリセットする。       
        }
    }

    void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("ground"))
        {
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
