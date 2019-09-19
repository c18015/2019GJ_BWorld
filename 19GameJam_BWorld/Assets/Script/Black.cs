using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Black : MonoBehaviour
{
    public Sprite white;
    public Sprite invi;
    public int click;

    void Update()
    {

        // 左クリックされた瞬間に実行
        if (Input.GetMouseButtonDown(0))
        {
            
            click++;
            switch (click)//クリックされた回数が
            {
                case (1):
                    this.gameObject.GetComponent<SpriteRenderer>().sprite = invi;//透明に変更
                    GetComponent<BoxCollider2D>().enabled = false;
                    break;
                    Debug.Log("OK");
                case (2):
                    this.gameObject.GetComponent<SpriteRenderer>().sprite = white;//白に変更
                    GetComponent<BoxCollider2D>().enabled = true;
                    click = 0;
                    break;
            }
        }
    }
}
