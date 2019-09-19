using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MarkDisplay : MonoBehaviour
{
    public GameObject Icon;
    public float Speed;
    
    Vector2 SP;
    // Start is called before the first frame update
    void Start()
    {
        Icon.SetActive(false);
        
    }

    void Update()
    {
        //Debug.Log(SP);
        //SP = GameObject.Find("hoge").transform.position;
    }

    void OnTriggerStay2D(Collider2D collider)
    {
        if (collider.gameObject.CompareTag("Player"))
        {
            Icon.SetActive(true);
        }

        if (Input.GetKey(KeyCode.B))
        {
            var hori = Input.GetAxisRaw("Horizontal");
            var rb = GetComponent<Rigidbody2D>();
            var vel = rb.velocity;
            vel.x = hori * Speed;
            rb.velocity = vel;

            Icon.SetActive(false);
        }

    }
    void OnTriggerExit2D(Collider2D collider)
    {
        if (collider.gameObject.CompareTag("Player"))
        {
            Icon.SetActive(false);
        }
            
    }

}
