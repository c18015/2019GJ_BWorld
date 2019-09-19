using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MarkDisplay : MonoBehaviour
{
    GameObject Icon;
    public float Speed;
    Vector3 pos;
    private AudioSource audioSource;
    public AudioClip Cory;
    // Start is called before the first frame update
    void Awake()
    {
        audioSource = gameObject.AddComponent<AudioSource>();

        GameObject player = GameObject.FindWithTag("Player");
        Icon = player.transform.GetChild(0).gameObject;
        Icon.SetActive(false);
        //自分の初期位置取得
        pos = this.gameObject.transform.position;
        //Debug.Log(Icon.name);
    }

    void OnTriggerStay2D(Collider2D collider)
    {
        if (collider.gameObject.CompareTag("Player"))
        {
            Icon.SetActive(true);
            if (Input.GetKey(KeyCode.B))
            {
                audioSource.PlayOneShot(Cory);
                var hori = Input.GetAxisRaw("Horizontal");
                var rb = GetComponent<Rigidbody2D>();
                var vel = rb.velocity;
                vel.x = hori * Speed;
                rb.velocity = vel;

                Icon.SetActive(false);
            }
        }
    }
    void OnTriggerExit2D(Collider2D collider)
    {
        if (collider.gameObject.CompareTag("Player"))
        {
            Icon.SetActive(false);
        }
            
    }
    void OnBecameInvisible()
    {

            this.gameObject.transform.position = pos;
    }

}
