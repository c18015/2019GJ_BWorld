using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SelectArrow : MonoBehaviour
{
    public GameObject StateON;
    public GameObject StateOFF;
    public GameObject HowON;
    public GameObject HowOFF;
    public GameObject AroUP;
    public GameObject AroDown;
    public GameObject HowToPlayPanel;

    bool HowtoPlay = true; //falseでON、trueでOFF
    bool StateGame = true; 

    // Start is called before the first frame update


    void Start()
    {
        StateOFF.SetActive(false);
        HowON.SetActive(false);
        AroDown.SetActive(false);
        HowToPlayPanel.SetActive(false);
        StateGame = false;

    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.DownArrow))
        {
            StateOFF.SetActive(true);
            StateON.SetActive(false);
            HowON.SetActive(true);
            HowOFF.SetActive(false);
            AroUP.SetActive(false);
            AroDown.SetActive(true);
            StateGame = true;
            
        }

        if (HowtoPlay && Input.GetKeyDown(KeyCode.UpArrow))
        {
            StateOFF.SetActive(false);
            StateON.SetActive(true);
            HowON.SetActive(false);
            HowOFF.SetActive(true);
            AroUP.SetActive(true);
            AroDown.SetActive(false);
            StateGame = false;

        }

        if (!StateGame && Input.GetKeyDown(KeyCode.Space))//Spaceを◯ボタンに変える
        {
            Debug.Log("State Game!");//ゲームシーンに飛ばす
        }
        if(StateGame && Input.GetKeyDown(KeyCode.Space)) //HowtoPlay = falseで操作説明を表示しているときは矢印を動かなくさせる
        {
            HowToPlayPanel.SetActive(true);
            HowtoPlay = false;
        }

        if (!HowtoPlay && Input.GetKeyDown(KeyCode.A))
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

    


}
