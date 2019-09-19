using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : PhysicsObject
{
    

    public float Speed = 5f;
    public float JumpPower = 8f; //ジャンプ力
    private SpriteRenderer spriteRenderer;

    bool floating = true;//ジャンプの判定

    private Animator anim;

    void Awake()
    {
        spriteRenderer = GetComponent<SpriteRenderer>();
    }

    void Start()
    {
        anim = GetComponent<Animator>();
    }



    protected override void ComputeVelocity()
    {
        Vector2 move = Vector2.zero;

        move.x = Input.GetAxis("Horizontal");

        if (Input.GetButtonDown("Jump2") && grounded)
        {
            velocity.y = JumpPower;
        }
        else if (Input.GetButtonUp("Jump2"))
        {
            if (velocity.y > 0)
            {
                velocity.y = velocity.y * 0.5f;
            }
        }
        

        targetVelocity = move * Speed;
    }











    

    /*
    void Update()
    {
        var hori = Input.GetAxisRaw("Horizontal");
        var rb = GetComponent<Rigidbody2D>();
        var vel = rb.velocity;
        vel.x = hori;

        if (vel.x != 0)
        {
            Vector2 temp = transform.localScale;
            temp.x = hori * 1.56f;
            transform.localScale = temp;
            anim.SetBool("Dash", true);
        }
        else { anim.SetBool("Dash", false); }
    }

    void OnCollisionEnter2D(Collision2D collision)
    {
        

        if (collision.gameObject.CompareTag("Damage"))
        {
            //無敵処理＆ダメージの挙動制す者
            StartCoroutine("muteki");
            
        }
    }
  
    IEnumerator muteki()
    {
        yield return new WaitForSeconds(1.0f);
        // transformを取得
        Transform myTransform = this.transform;

        // リスポーン地点に設定
        Vector2 pos = myTransform.position;
        pos.x = 5;    // x座標
        pos.y = -1;    // y座標

        myTransform.position = pos;  // 座標を設定

        this.gameObject.GetComponent<Life>().damageOn();
    }

}
