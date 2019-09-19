using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Damage : MonoBehaviour
{
    void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            //Debug.Log("当たった");
            var hit = collision.gameObject;　//varは型理論
            var Health = hit.GetComponent<Life>();
            //LifeスクリプトからのTakeDamage への呼び出しを追加

            if (Health != null) //Null値が入力されてなければ
            {
                Health.TakeDamage(1); //1ダメージ
            }
        }
    }
}
