using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;

public class ParkClick5 : MonoBehaviour
{   
    public GameObject Correct;
    public Button Button1;

    private static int Bt1Check = 0;

    public static int ItemsClicked = 0;

    private void Start()
    {
        ItemsClicked = 0;
            
        Bt1Check = 0;
    }

    public void Update()
    {
        if (ItemsClicked == 0)
        {   
            if (Button1.interactable == false)
            {
                ItemsClicked++;
                Bt1Check++;
            }
        }
    }
}
