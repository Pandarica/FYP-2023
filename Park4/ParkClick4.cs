using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;

public class ParkClick4 : MonoBehaviour
{   
    public GameObject Correct;
    public Button Button1;
    public Button Button2;

    private static int Bt1Check = 0;
    private static int Bt2Check = 0;

    public static int ItemsClicked = 0;

    private void Start()
    {
        ItemsClicked = 0;
            
        Bt1Check = 0;
        Bt2Check = 0;
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
            else if (Button2.interactable == false)
            {
                ItemsClicked++;
                Bt2Check++;
            }
        }
        else if (ItemsClicked == 1)
        {
            if (Button1.interactable == false && Bt1Check == 0)
            {
                ItemsClicked++;
                Bt1Check++;
            }
            else if (Button2.interactable == false && Bt2Check == 0)
            {
                ItemsClicked++;
                Bt2Check++;
            }
        }
    }
}
