using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;

public class KitchenClick2 : MonoBehaviour
{   
    public GameObject Correct;
    public Button Button1;
    public Button Button2;
    public Button Button3;
    public Button Button4;
    public Button Button5;
    public Button Button6;
    public Button Button7;
    public Button Button8;

    private static int Bt1Check = 0;
    private static int Bt2Check = 0;
    private static int Bt3Check = 0;
    private static int Bt4Check = 0;
    private static int Bt5Check = 0;
    private static int Bt6Check = 0;
    private static int Bt7Check = 0;
    private static int Bt8Check = 0;

    public static int ItemsClicked = 0;

    private void Start()
    {
        ItemsClicked = 0;
            
        Bt1Check = 0;
        Bt2Check = 0;
        Bt3Check = 0;
        Bt4Check = 0;
        Bt5Check = 0;
        Bt6Check = 0;
        Bt7Check = 0;
        Bt8Check = 0;
    }

    public void Update()
    {
        if (ItemsClicked == 0)
        {   
            Debug.Log(ItemsClicked);
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
            else if (Button3.interactable == false)
            {
                ItemsClicked++;
                Bt3Check++;
            }
            else if (Button4.interactable == false)
            {
                ItemsClicked++;
                Bt4Check++;
            }
            else if (Button5.interactable == false)
            {
                ItemsClicked++;
                Bt5Check++;
            }
            else if (Button6.interactable == false)
            {
                ItemsClicked++;
                Bt6Check++;
            }
            else if (Button7.interactable == false)
            {
                ItemsClicked++;
                Bt7Check++;
            }
            else if (Button8.interactable == false)
            {
                ItemsClicked++;
                Bt8Check++;
            }
        }
        else if (ItemsClicked == 1)
        {
            Debug.Log(ItemsClicked);
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
            else if (Button3.interactable == false && Bt3Check == 0)
            {
                ItemsClicked++;
                Bt3Check++;
            }
            else if (Button4.interactable == false && Bt4Check == 0)
            {
                ItemsClicked++;
                Bt4Check++;
            }
            else if (Button5.interactable == false && Bt5Check == 0)
            {
                ItemsClicked++;
                Bt5Check++;
            }
            else if (Button6.interactable == false && Bt6Check == 0)
            {
                ItemsClicked++;
                Bt6Check++;
            }
            else if (Button7.interactable == false && Bt7Check == 0)
            {
                ItemsClicked++;
                Bt7Check++;
            }
            else if (Button8.interactable == false && Bt8Check == 0)
            {
                ItemsClicked++;
                Bt8Check++;
            }
        }
        else if (ItemsClicked == 2)
        {
            Debug.Log(ItemsClicked);
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
            else if (Button3.interactable == false && Bt3Check == 0)
            {
                ItemsClicked++;
                Bt3Check++;
            }
            else if (Button4.interactable == false && Bt4Check == 0)
            {
                ItemsClicked++;
                Bt4Check++;
            }
            else if (Button5.interactable == false && Bt5Check == 0)
            {
                ItemsClicked++;
                Bt5Check++;
            }
            else if (Button6.interactable == false && Bt6Check == 0)
            {
                ItemsClicked++;
                Bt6Check++;
            }
            else if (Button7.interactable == false && Bt7Check == 0)
            {
                ItemsClicked++;
                Bt7Check++;
            }
            else if (Button8.interactable == false && Bt8Check == 0)
            {
                ItemsClicked++;
                Bt8Check++;
            }
        }
        else if (ItemsClicked == 3)
        {   
            Debug.Log(ItemsClicked);
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
            else if (Button3.interactable == false && Bt3Check == 0)
            {
                ItemsClicked++;
                Bt3Check++;
            }
            else if (Button4.interactable == false && Bt4Check == 0)
            {
                ItemsClicked++;
                Bt4Check++;
            }
            else if (Button5.interactable == false && Bt5Check == 0)
            {
                ItemsClicked++;
                Bt5Check++;
            }
            else if (Button6.interactable == false && Bt6Check == 0)
            {
                ItemsClicked++;
                Bt6Check++;
            }
            else if (Button7.interactable == false && Bt7Check == 0)
            {
                ItemsClicked++;
                Bt7Check++;
            }
            else if (Button8.interactable == false && Bt8Check == 0)
            {
                ItemsClicked++;
                Bt8Check++;
            }
        }
        else if (ItemsClicked == 4)
        {   
            Debug.Log(ItemsClicked);
        }
    }
}
