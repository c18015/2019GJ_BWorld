using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class White : MonoBehaviour
{
    public Sprite invi;
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
                case (1)://1回目の時
                    this.gameObject.GetComponent<Image>().sprite = black;//黒に変更
                    GetComponent<BoxCollider2D>().enabled = true;
                    break;
                case (2)://2回目の時
                    this.gameObject.GetComponent<Image>().sprite = invi;//透明に変更
                    GetComponent<BoxCollider2D>().enabled = false;
                    click = 0;//クリック回数の0に
                    break;
            }
        }
    }
}
