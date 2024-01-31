using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using ChangeTxt;

namespace KtTxt4
{
    public class KitchenTxt4 : MonoBehaviour
    {
        public TMP_Text KitchenScoreText4;
        public TMP_Text KitchenQnText4;


        void Start()
        {
            KitchenScoreText4.text = ChangeTxt.ChangeTMPText.score13;
            KitchenQnText4.text = ChangeTxt.ChangeTMPText.qn41;
        }

        void Update()
        {
            if (KitchenClick4.ItemsClicked == 1)
            {
                KitchenScoreText4.text = ChangeTxt.ChangeTMPText.score14;
                KitchenQnText4.text = ChangeTxt.ChangeTMPText.qn42;
            }
            else if (KitchenClick4.ItemsClicked == 2)
            {
                KitchenScoreText4.text = ChangeTxt.ChangeTMPText.score15;
            }
        }
    }
}