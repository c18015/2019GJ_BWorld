using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LifeIcon : MonoBehaviour
{
    public GameObject[] icons; //ライフ（アイコンいれて）

    public void UpdateLife(int Life) //外部からライフの残基を受け取る
    {
        for (int i = 0; i < icons.Length; i++)
        {
            if (i < Life) icons[i].SetActive(true);
            else icons[i].SetActive(false);
        }
    }
}
