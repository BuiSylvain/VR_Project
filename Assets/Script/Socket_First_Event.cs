using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.XR.Interaction.Toolkit;

public class Socket_First_Event : MonoBehaviour
{
    public int Compteur = 0;
    public void OnSelect(SelectEnterEventArgs args)
    {
        Compteur++;
    }

    public void Update()
    {
        if (Compteur == 2)
        {
           
            this.gameObject.transform.Find("PiratesChest_A1").gameObject.transform.Find("PiratesChest_Cap").gameObject.SetActive(false);
            this.gameObject.transform.Find("PiratesChest_A1").gameObject.transform.Find("Red_Key").gameObject.SetActive(true);

            //GameManager.instance.OnTask1Done();
        }
    }
}
