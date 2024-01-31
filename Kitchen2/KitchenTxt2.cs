using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using ChangeTxt;

namespace KtTxt2
{
    public class KitchenTxt2 : MonoBehaviour
    {
        public TMP_Text KitchenScoreText2;
        public TMP_Text KitchenQnText2;


        void Start()
        {
            KitchenScoreText2.text = ChangeTxt.ChangeTMPText.score6;
            KitchenQnText2.text = ChangeTxt.ChangeTMPText.qn21;
        }

        void Update()
        {
            if (KitchenClick2.ItemsClicked == 1)
            {
                KitchenScoreText2.text = ChangeTxt.ChangeTMPText.score7;
                KitchenQnText2.text = ChangeTxt.ChangeTMPText.qn22;
            }
            else if (KitchenClick2.ItemsClicked == 2)
            {
                KitchenScoreText2.text = ChangeTxt.ChangeTMPText.score8;
                KitchenQnText2.text = ChangeTxt.ChangeTMPText.qn23;
            }
            else if (KitchenClick2.ItemsClicked == 3)
            {
                KitchenScoreText2.text = ChangeTxt.ChangeTMPText.score9;
                KitchenQnText2.text = ChangeTxt.ChangeTMPText.qn24;
            }
            else if (KitchenClick2.ItemsClicked == 4)
            {
                KitchenScoreText2.text = ChangeTxt.ChangeTMPText.score10;
            }
        }
    }
}