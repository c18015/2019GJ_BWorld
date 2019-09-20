using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SelectArrow : MonoBehaviour
{
    public GameObject StateON;
    public GameObject StateOFF;
    public GameObject HowON;
    public GameObject HowOFF;
    public GameObject AroUP;
    public GameObject AroDown;
    public GameObject HowToPlayPanel;

    private AudioSource[] sources;
    public float Number = 0f;

    bool HowtoPlay = true; //falseでON、trueでOFF
    bool StateGame = true;
    bool ONON = true;

    // Start is called before the first frame update


    void Start()
    {
        StateOFF.SetActive(false);
        HowON.SetActive(false);
        AroDown.SetActive(false);
        HowToPlayPanel.SetActive(false);
        StateGame = false;


        sources = gameObject.GetComponents<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {
        var hori = Input.GetAxisRaw("Vertical");
        float Check = hori;
        if (Check == 1)//スティックを下げた時
        {
            if (ONON)
            {
                StateOFF.SetActive(true);
                StateON.SetActive(false);
                HowON.SetActive(true);
                HowOFF.SetActive(false);
                AroUP.SetActive(false);
                AroDown.SetActive(true);
                StateGame = true;
                ONON = false;

            }
            
        }
        if(Check == -1)//スティックを上げた時
        {
            Debug.Log("age");
            if (!ONON)
            {
                StateOFF.SetActive(false);
                StateON.SetActive(true);
                HowON.SetActive(false);
                HowOFF.SetActive(true);
                AroUP.SetActive(true);
                AroDown.SetActive(false);
                StateGame = false;
                ONON = true;

            }
        }


            

        

        if (!StateGame && Input.GetButtonDown("Jump2"))//Spaceを◯ボタンに変える
        {
            Debug.Log("State Game!");//ゲームシーンに飛ばす


            if (Number == 1)
            {
                Invoke("GoMain", 1f);//--メインに飛ぶ
            }
            sources[0].Play();
        }
        if(StateGame && Input.GetButtonDown("Jump2")) //HowtoPlay = falseで操作説明を表示しているときは矢印を動かなくさせる
        {
            HowToPlayPanel.SetActive(true);
            HowtoPlay = false;
            sources[0].Play();
        }

        if (!HowtoPlay && Input.GetButtonDown("BlockMove"))
        {
            HowToPlayPanel.SetActive(false);
            HowtoPlay = true;
            StateOFF.SetActive(true);
            StateON.SetActive(false);
            HowON.SetActive(true);
            HowOFF.SetActive(false);
            AroUP.SetActive(false);
            AroDown.SetActive(true);
            StateGame = true;
        }


    }

    void GoMain()
    {
        SceneManager.LoadScene("Stage1");
    }




}
