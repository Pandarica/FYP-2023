using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using ChangeTxt;

namespace KtTxt3
{
    public class KitchenTxt3 : MonoBehaviour
    {
        public TMP_Text KitchenScoreText3;
        public TMP_Text KitchenQnText3;


        void Start()
        {
            KitchenScoreText3.text = ChangeTxt.ChangeTMPText.score10;
            KitchenQnText3.text = ChangeTxt.ChangeTMPText.qn31;
        }

        void Update()
        {
            if (KitchenClick3.ItemsClicked == 1)
            {
                KitchenScoreText3.text = ChangeTxt.ChangeTMPText.score11;
                KitchenQnText3.text = ChangeTxt.ChangeTMPText.qn32;
            }
            else if (KitchenClick3.ItemsClicked == 2)
            {
                KitchenScoreText3.text = ChangeTxt.ChangeTMPText.score12;
                KitchenQnText3.text = ChangeTxt.ChangeTMPText.qn33;
            }
            else if (KitchenClick3.ItemsClicked == 3)
            {
                KitchenScoreText3.text = ChangeTxt.ChangeTMPText.score13;
            }
        }
    }
}