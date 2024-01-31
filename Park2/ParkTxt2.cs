using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using ChangeTxt;

namespace PkTxt2
{
    public class ParkTxt2 : MonoBehaviour
    {
        public TMP_Text ParkScoreText2;
        public TMP_Text ParkQnText2;

        void Start()
        {
            ParkScoreText2.text = ChangeTxt.ChangeTMPText.score6;
            ParkQnText2.text = ChangeTxt.ChangeTMPText.qn21;
        }

        void Update()
        {
            if (ParkClick2.ItemsClicked == 1)
            {
                ParkScoreText2.text = ChangeTxt.ChangeTMPText.score7;
                ParkQnText2.text = ChangeTxt.ChangeTMPText.qn22;
            }
            else if (ParkClick2.ItemsClicked == 2)
            {
                ParkScoreText2.text = ChangeTxt.ChangeTMPText.score8;
                ParkQnText2.text = ChangeTxt.ChangeTMPText.qn23;
            }
            else if (ParkClick2.ItemsClicked == 3)
            {
                ParkScoreText2.text = ChangeTxt.ChangeTMPText.score9;
                ParkQnText2.text = ChangeTxt.ChangeTMPText.qn24;
            }
            else if (ParkClick2.ItemsClicked == 4)
            {
                ParkScoreText2.text = ChangeTxt.ChangeTMPText.score10;
            }
        }
    }
}