using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : PhysicsObject
{

<<<<<<< HEAD
    public float Speed = 3f;
    int Nomove = 1;
=======

    public float Speed = 5f;
    public float JumpPower = 8f; //ジャンプ力
    private SpriteRenderer spriteRenderer;

>>>>>>> bab488e14d982341be988c9d65c883d48b8c9358
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
<<<<<<< HEAD
        var hori = Input.GetAxisRaw("Horizontal");
        var rb = GetComponent<Rigidbody2D>();
        var vel = rb.velocity;
        vel.x = hori * Speed * Nomove;
        rb.velocity = vel;
        if (vel.x != 0)
=======
        Vector2 move = Vector2.zero;

        move.x = Input.GetAxis("Horizontal");

        if (Input.GetButtonDown("Jump2") && grounded)
>>>>>>> bab488e14d982341be988c9d65c883d48b8c9358
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
<<<<<<< HEAD
            var rb = GetComponent<Rigidbody2D>();
            rb.AddForce(new Vector2(0f, flameCount * Nomove), ForceMode2D.Impulse);//addforceでFlameCount分、上に移動
            floating = false;       //ジャンプ判定をoff
            //flameCount = 0;         //フレームカウントをリセットする。   

            /*
            flameCount = flameCount + 20 * Time.deltaTime;//押している間flameCountが増える
            //Debug.Log(flameCount);
            if (flameCount >= 4.6f)
            {
                flameCount = 4.5f;//ジャンプ力の上限
            }*/
=======
            Vector2 temp = transform.localScale;
            temp.x = hori * 1.56f;
            transform.localScale = temp;
            anim.SetBool("Dash", true);
>>>>>>> bab488e14d982341be988c9d65c883d48b8c9358
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
        Nomove = 0;
        anim.SetTrigger("Death");
        yield return new WaitForSeconds(0.9f);

        // transformを取得
        Transform myTransform = this.transform;

        // リスポーン地点に設定
        Vector2 pos = myTransform.position;
        pos.x = 5;    // x座標
        pos.y = -1;    // y座標

        myTransform.position = pos;  // 座標を設定

        this.gameObject.GetComponent<Life>().damageOn();
        Nomove = 1;
    }

}*/
