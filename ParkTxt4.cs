using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using ChangeTxt;

namespace PkTxt4
{
    public class ParkTxt4 : MonoBehaviour
    {
        public TMP_Text ParkScoreText4;
        public TMP_Text ParkQnText4;

        void Start()
        {
            ParkScoreText4.text = ChangeTxt.ChangeTMPText.score13;
            ParkQnText4.text = ChangeTxt.ChangeTMPText.qn41;
        }

        void Update()
        {
            if (ParkClick4.ItemsClicked == 1)
            {
                ParkScoreText4.text = ChangeTxt.ChangeTMPText.score14;
                ParkQnText4.text = ChangeTxt.ChangeTMPText.qn42;
            }
            else if (ParkClick4.ItemsClicked == 2)
            {
                ParkScoreText4.text = ChangeTxt.ChangeTMPText.score15;
            }
        }
    }
}