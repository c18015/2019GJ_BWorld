using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class NEstSen : MonoBehaviour
{

    private AudioSource[] sources;
    public float Number = 0f;

    bool ooo = false;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

        if (ooo && Input.GetButtonDown("BlockMove"))
        {
            if (Number == 1)
            {
                Invoke("GoMain", 1f);//--メインに飛ぶ
            }
        }

        

        
    }
    void OnTriggerExit2D(Collider2D collider)
    {
        if (collider.gameObject.CompareTag("G"))
        {
            if (Number == 2)
            {
                Invoke("GoS2", 1f);//--メインに飛ぶ
            }

            if (Number == 3)
            {
                Invoke("GoS3", 1f);//--メインに飛ぶ
            }
        }

    }

    void GoMain()
    {
        SceneManager.LoadScene("Stage1");
    }

    void GoS2()
    {
        SceneManager.LoadScene("Stage2");
    }

    void GoS3()
    {
        SceneManager.LoadScene("Stage3");
    }
}
