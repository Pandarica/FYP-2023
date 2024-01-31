using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using ChangeTxt;

namespace PkTxt3
{
    public class ParkTxt3 : MonoBehaviour
    {
        public TMP_Text ParkScoreText3;
        public TMP_Text ParkQnText3;

        void Start()
        {
            ParkScoreText3.text = ChangeTxt.ChangeTMPText.score10;
            ParkQnText3.text = ChangeTxt.ChangeTMPText.qn31;
        }

        void Update()
        {
            if (ParkClick3.ItemsClicked == 1)
            {
                ParkScoreText3.text = ChangeTxt.ChangeTMPText.score11;
                ParkQnText3.text = ChangeTxt.ChangeTMPText.qn32;
            }
            else if (ParkClick3.ItemsClicked == 2)
            {
                ParkScoreText3.text = ChangeTxt.ChangeTMPText.score12;
                ParkQnText3.text = ChangeTxt.ChangeTMPText.qn33;
            }
            else if (ParkClick3.ItemsClicked == 3)
            {
                ParkScoreText3.text = ChangeTxt.ChangeTMPText.score13;
            }
        }
    }
}