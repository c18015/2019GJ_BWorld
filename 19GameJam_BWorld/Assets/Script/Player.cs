using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    public float speed;
    public float jumpPower;
    Rigidbody2D Rigi;
    Animation anim;


    // Use this for initialization
    void Start()
    {
        Rigi = GetComponent<Rigidbody2D>();
        //anim = this.gameObject.GetComponent<Animation>();



    }

    // Update is called once per frame
    void Update()
    {


        float inputHor = Input.GetAxis("Horizontal");

        if (inputHor != 0)
        {
            lockmanRun(inputHor);
            //anim.Play();
        }

        if (Input.GetKeyDown(KeyCode.Space))
        {
            lockmanjump();
        }

    }

    void lockmanjump()
    {
        Rigi.AddForce(new Vector2(0, 100 * Time.deltaTime * jumpPower));
    }


    void lockmanRun(float InputX)
    {

        if (InputX > 0)//キャラの臥像を進行方向に反転
        {
            this.transform.localScale = new Vector3(1, 1, 1);
        }
        else
        {
            this.transform.localScale = new Vector3(-1, 1, 1);
        }


        InputX = (int)Mathf.Clamp(InputX * 5000, -1, 1);
        this.transform.localScale = new Vector3(InputX, 1, 1);
        this.transform.Translate(InputX * Time.deltaTime * speed, 0, 0);


    }
}
