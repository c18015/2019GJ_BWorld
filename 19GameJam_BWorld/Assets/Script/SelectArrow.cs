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
    // Start is called before the first frame update


    void Start()
    {
        StateOFF.SetActive(false);
        HowON.SetActive(false);
        AroDown.SetActive(false);

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
            
        }

        if (Input.GetKeyDown(KeyCode.UpArrow))
        {
            StateOFF.SetActive(false);
            StateON.SetActive(true);
            HowON.SetActive(false);
            HowOFF.SetActive(true);
            AroUP.SetActive(true);
            AroDown.SetActive(false);

        }
    }


}
