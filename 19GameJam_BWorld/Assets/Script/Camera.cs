using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Camera : MonoBehaviour
{
    public GameObject player;

    void Start()
    { 
    }

    void Update()
    {
        //カメラがプレイヤーを追従する。
        transform.position = new Vector3(player.transform.position.x, 0, -10);

        if (transform.position.x < 0)
        {
            transform.position = new Vector3(0, 0, -10);
        }

        if (transform.position.x >= 18)
        {
            transform.position = new Vector3(18, 0, -10);
        }
    }
}

