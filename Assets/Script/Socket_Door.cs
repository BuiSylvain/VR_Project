using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.XR.Interaction.Toolkit;

public class Socket_Door : MonoBehaviour
{
    private int Key = 0;
    public void OnSelect(SelectEnterEventArgs args)
    {
        Key++;


    }

    public void Update()
    {
        Debug.Log(Key);
        if(Key == 3)
        {
            //GameManager.instance.OnTask1Done();
        }
    }

}

