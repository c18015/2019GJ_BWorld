using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerAni : MonoBehaviour
{

    private Animator anim;
    bool Checker = true;
    bool Checker2 = true;
    Rigidbody2D rb;
    float www;

    // Start is called before the first frame update
    void Start()
    {
        anim = GetComponent<Animator>();
    }



    
    void Update()
    {


        var hori = Input.GetAxisRaw("Horizontal");
        //Vector2 temp = transform.localScale;
        //temp.x = hori * 1.56f;
        //var rb = GetComponent<Rigidbody2D>();
        //var vel = rb.velocity;
        //vel.x = hori;
        
        
        if(hori >= 0.5)
        {
            www = 1;
        }else if(hori <= -0.5)
        {
            www = -1;
        }
        else
        {
            www = 0;
        }

        Debug.Log(www);

        if (www == 1)
        {
            
            if (!Checker)
            {
                //Debug.Log("→");

                this.transform.Rotate(0, 180, 0);
                Checker = true;
                Checker2 = true;
            }
        }

        if (www == -1)
        {

            if (Checker2)
            {
                //Debug.Log("←");
                
                this.transform.Rotate(0, 180, 0);
                Checker2 = false;
                Checker = false;

            }
        }



        if (hori != 0)
        {
            /*Vector2 temp = transform.localScale;
            temp.x = hori * 1.56f;
            transform.localScale = temp;*/
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
