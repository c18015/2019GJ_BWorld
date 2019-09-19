﻿using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class Life : MonoBehaviour
{
   public LifeIcon lifeIcon; //ライフパネル

    public const int maxHealth = 3; //最大残基3
    public int life;//のこり残基
    public static int Health;//減った残基数
    private AudioSource audioSource; //音楽流すやつ

    public AudioClip Death;
    bool damage = true;
    public void Awake()
    {
        audioSource = gameObject.AddComponent<AudioSource>();
        life = maxHealth - Life.Health;//staticの減った残基呼び出して、現残基の計算
        //Debug.Log(life);

        //シーン切り替え時にライフアイコン更新
        lifeIcon.UpdateLife(life);
        
    }

    public void TakeDamage(int amount) //外部のスクリプトから受け付け
    {
        if (damage)
        {
            audioSource.PlayOneShot(Death);//死ぬ音楽
            damage = false;
            Health += amount;//減った残基数
            life = maxHealth - Health;
            //ライフパネルを更新
            lifeIcon.UpdateLife(life);

            if (life == 0) //残り残基が0の時
            {
                //死んだときの処理
                
            }
        }     

    }

    public void damageOn()
    {
        damage = true;
    }
}
