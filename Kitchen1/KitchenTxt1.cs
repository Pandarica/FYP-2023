using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using ChangeTxt;

namespace KtTxt1
{
    public class KitchenTxt1 : MonoBehaviour
    {
        public TMP_Text KitchenScoreText1;
        public TMP_Text KitchenQnText1;


        void Start()
        {
            KitchenScoreText1.text = ChangeTxt.ChangeTMPText.score1;
            KitchenQnText1.text = ChangeTxt.ChangeTMPText.qn11;
        }

        void Update()
        {
            if (KitchenClick1.ItemsClicked == 1)
            {
                KitchenScoreText1.text = ChangeTxt.ChangeTMPText.score2;
                KitchenQnText1.text = ChangeTxt.ChangeTMPText.qn12;
            }
            else if (KitchenClick1.ItemsClicked == 2)
            {
                KitchenScoreText1.text = ChangeTxt.ChangeTMPText.score3;
                KitchenQnText1.text = ChangeTxt.ChangeTMPText.qn13;
            }
            else if (KitchenClick1.ItemsClicked == 3)
            {
                KitchenScoreText1.text = ChangeTxt.ChangeTMPText.score4;
                KitchenQnText1.text = ChangeTxt.ChangeTMPText.qn14;
            }
            else if (KitchenClick1.ItemsClicked == 4)
            {
                KitchenScoreText1.text = ChangeTxt.ChangeTMPText.score5;
                KitchenQnText1.text = ChangeTxt.ChangeTMPText.qn15;
            }
            else if (KitchenClick1.ItemsClicked == 5)
            {
                KitchenScoreText1.text = ChangeTxt.ChangeTMPText.score6;

            }
        }
    }
}