using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.XR.Interaction.Toolkit;

public class Socket_3rd_Event : MonoBehaviour
{
    private int Turn = 0;
    public void OnSelect(SelectEnterEventArgs args)
    {

        if(Turn == 0)
        {
            Turn = 1;
            this.gameObject.transform.Find("Point Light").gameObject.SetActive(false);
            this.gameObject.transform.Find("Mur 3").gameObject.transform.Find("Red_Key3").gameObject.SetActive(true);
        }
        else
        {
            Turn = 0;
            this.gameObject.transform.Find("Point Light").gameObject.SetActive(true);
            this.gameObject.transform.Find("Mur 3").gameObject.transform.Find("Red_Key3").gameObject.SetActive(false);
        }


    }


}
