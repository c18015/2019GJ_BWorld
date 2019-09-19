using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerAni : MonoBehaviour
{

    private Animator anim;
    // Start is called before the first frame update
    void Start()
    {
        anim = GetComponent<Animator>();
    }



    
    void Update()
    {


        var hori = Input.GetAxisRaw("Horizontal");

        /*
        var rb = GetComponent<Rigidbody2D>();
        var vel = rb.velocity;
        vel.x = hori;
        
         Vector2 temp = transform.localScale;
            temp.x = hori * 1.56f;
            transform.localScale = temp;
         */

        if (hori != 0)
        {
            anim.SetBool("Dash", true);
        }
        else { anim.SetBool("Dash", false); }
    }

    void OnCollisionEnter2D(Collision2D collision)
    {
        

        if (collision.gameObject.CompareTag("Damage"))
        {

            // transformを取得
            Transform myTransform = this.transform;

            // リスポーン地点に設定
            Vector2 pos = myTransform.position;
            pos.x = 5;    // x座標
            pos.y = -1;    // y座標

            myTransform.position = pos;  // 座標を設定

        }
    }
  
    

}
