using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using ChangeTxt;

namespace PkTxt1
{
    public class ParkTxt1 : MonoBehaviour
    {
        public TMP_Text ParkScoreText1;
        public TMP_Text ParkQnText1;

        void Start()
        {
            ParkScoreText1.text = ChangeTxt.ChangeTMPText.score1;
            ParkQnText1.text = ChangeTxt.ChangeTMPText.qn11;
        }

        void Update()
        {
            if (ParkClick1.ItemsClicked == 1)
            {
                ParkScoreText1.text = ChangeTxt.ChangeTMPText.score2;
                ParkQnText1.text = ChangeTxt.ChangeTMPText.qn12;
            }
            else if (ParkClick1.ItemsClicked == 2)
            {
                ParkScoreText1.text = ChangeTxt.ChangeTMPText.score3;
                ParkQnText1.text = ChangeTxt.ChangeTMPText.qn13;
            }
            else if (ParkClick1.ItemsClicked == 3)
            {
                ParkScoreText1.text = ChangeTxt.ChangeTMPText.score4;
                ParkQnText1.text = ChangeTxt.ChangeTMPText.qn14;
            }
            else if (ParkClick1.ItemsClicked == 4)
            {
                ParkScoreText1.text = ChangeTxt.ChangeTMPText.score5;
                ParkQnText1.text = ChangeTxt.ChangeTMPText.qn15;
            }
            else if (ParkClick1.ItemsClicked == 5)
            {
                ParkScoreText1.text = ChangeTxt.ChangeTMPText.score6;
            }
        }
    }
}