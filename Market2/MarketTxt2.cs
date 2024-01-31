using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using ChangeTxt;

namespace MtTxt2
{
    public class MarketTxt2 : MonoBehaviour
    {
        public TMP_Text MarketScoreText2;
        public TMP_Text MarketQnText2;


        void Start()
        {
            MarketScoreText2.text = ChangeTxt.ChangeTMPText.score6;
            MarketQnText2.text = ChangeTxt.ChangeTMPText.qn21;
        }

        void Update()
        {
            if (MarketClick2.ItemsClicked == 1)
            {
                MarketScoreText2.text = ChangeTxt.ChangeTMPText.score7;
                MarketQnText2.text = ChangeTxt.ChangeTMPText.qn22;
            }
            else if (MarketClick2.ItemsClicked == 2)
            {
                MarketScoreText2.text = ChangeTxt.ChangeTMPText.score8;
                MarketQnText2.text = ChangeTxt.ChangeTMPText.qn23;
            }
            else if (MarketClick2.ItemsClicked == 3)
            {
                MarketScoreText2.text = ChangeTxt.ChangeTMPText.score9;
                MarketQnText2.text = ChangeTxt.ChangeTMPText.qn24;
            }
            else if (MarketClick2.ItemsClicked == 4)
            {
                MarketScoreText2.text = ChangeTxt.ChangeTMPText.score10;
            }
        }
    }
}