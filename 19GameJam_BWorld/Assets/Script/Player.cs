using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    public float Speed = 40f;
    float HorizontalMove = 0f;
    bool jump = false;
    public CharacterController2D controller;
    
    private Animator anim;

    void Start()
    {
        anim = GetComponent<Animator>();
    }
    

    void Update()
    {
        HorizontalMove = Input.GetAxisRaw("Horizontal") * Speed;

        if (Input.GetKeyDown(KeyCode.Space))
        {
            jump = true;
        }
    }

    void FixedUpdate()
    {
        controller.Move (HorizontalMove * Time.fixedDeltaTime, false , jump);
        jump = false;
    }

    void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("ground") || collision.gameObject.CompareTag("MoveBlock"))
        {
            
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
