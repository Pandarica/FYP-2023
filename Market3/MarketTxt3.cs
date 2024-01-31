using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using ChangeTxt;

namespace MtTxt3
{
    public class MarketTxt3 : MonoBehaviour
    {
        public TMP_Text MarketScoreText3;
        public TMP_Text MarketQnText3;


        void Start()
        {
            MarketScoreText3.text = ChangeTxt.ChangeTMPText.score10;
            MarketQnText3.text = ChangeTxt.ChangeTMPText.qn31;
        }

        void Update()
        {
            if (MarketClick3.ItemsClicked == 1)
            {
                MarketScoreText3.text = ChangeTxt.ChangeTMPText.score11;
                MarketQnText3.text = ChangeTxt.ChangeTMPText.qn32;
            }
            else if (MarketClick3.ItemsClicked == 2)
            {
                MarketScoreText3.text = ChangeTxt.ChangeTMPText.score12;
                MarketQnText3.text = ChangeTxt.ChangeTMPText.qn33;
            }
            else if (MarketClick3.ItemsClicked == 3)
            {
                MarketScoreText3.text = ChangeTxt.ChangeTMPText.score13;
            }
        }
    }
}