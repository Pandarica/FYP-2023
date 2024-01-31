using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;

namespace KtCk5
{
    public class KitchenClick5 : MonoBehaviour
    {
        public GameObject Correct;

        public Button Button1;

        public static int ItemsClicked = 0;

        private void Start()
        {
            ItemsClicked = 0;
        }

        public void Update()
        {
            if (ItemsClicked == 0)
            {
                if (Button1.interactable == false)
                {
                    ItemsClicked++;
                }
            }
        }
    }
}
