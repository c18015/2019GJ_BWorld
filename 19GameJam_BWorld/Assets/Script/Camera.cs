using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Camera : MonoBehaviour
{
   GameObject player;


    void Start()
    {
        player = GameObject.FindWithTag("Player");
    }

    void Update()
    {
        //カメラがプレイヤーを追従する。
        transform.position = new Vector2(player.transform.position.x +1, player.transform.position.y + 0.5f);

        if (transform.position.x < 0)
        {
            transform.position = new Vector2(0, 0);
        }

        if (transform.position.x >= 18)
        {
            transform.position = new Vector2(18, 0);
        }
    }
}

