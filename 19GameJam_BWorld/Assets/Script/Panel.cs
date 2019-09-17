using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Panel : MonoBehaviour
{
    public Sprite white;
    public Sprite black;
    int click;

    void Update()
    {
        // 左クリックされた瞬間に実行
        if (Input.GetMouseButtonDown(0))
        {

            click++;
            switch (click)//クリックされた回数が
            {
                case (1):
                    this.gameObject.GetComponent<SpriteRenderer>().sprite = white;//白に変更
                    break;
                case (2):
                    this.gameObject.GetComponent<SpriteRenderer>().sprite = black;//黒に変更
                    click = 0;
                    break;
            }
        }
    }
}