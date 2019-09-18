using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScrollObject : MonoBehaviour
{
    public float speed = 1.0f;
    public float upPosition;
    public float downPosition;
    bool move = false; 
    void Update()
    {
        switch (move)
        {
            case true:
                //毎フレームｘポジションを少しづつ移動移動させる
                transform.Translate(0,-1 * speed * Time.deltaTime, 0);
                break;
            case false:
                //毎フレームｘポジションを少しづつ移動移動させる
                transform.Translate(0, 1 * speed * Time.deltaTime, 0);
                break;
        }
        
        //スクロールが目標ポイントまで到着したかをチェック
        if (Mathf.Ceil(transform.position.y) == downPosition) move = false;
        if (Mathf.Ceil(transform.position.y) == upPosition) move = true;

    }

}
