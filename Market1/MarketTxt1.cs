using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using ChangeTxt;

namespace MtTxt1
{
    public class MarketTxt1 : MonoBehaviour
    {
        public TMP_Text MarketScoreText1;
        public TMP_Text MarketQnText1;


        void Start()
        {
            MarketScoreText1.text = ChangeTxt.ChangeTMPText.score1;
            MarketQnText1.text = ChangeTxt.ChangeTMPText.qn11;
        }

        void Update()
        {
            if (MarketClick1.ItemsClicked == 1)
            {
                MarketScoreText1.text = ChangeTxt.ChangeTMPText.score2;
                MarketQnText1.text = ChangeTxt.ChangeTMPText.qn12;
            }
            else if (MarketClick1.ItemsClicked == 2)
            {
                MarketScoreText1.text = ChangeTxt.ChangeTMPText.score3;
                MarketQnText1.text = ChangeTxt.ChangeTMPText.qn13;
            }
            else if (MarketClick1.ItemsClicked == 3)
            {
                MarketScoreText1.text = ChangeTxt.ChangeTMPText.score4;
                MarketQnText1.text = ChangeTxt.ChangeTMPText.qn14;
            }
            else if (MarketClick1.ItemsClicked == 4)
            {
                MarketScoreText1.text = ChangeTxt.ChangeTMPText.score5;
                MarketQnText1.text = ChangeTxt.ChangeTMPText.qn15;
            }
            else if (MarketClick1.ItemsClicked == 5)
            {
                MarketScoreText1.text = ChangeTxt.ChangeTMPText.score6;
            }
        }
    }
}