using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using ChangeTxt;

namespace PkTxt5
{
    public class ParkTxt5 : MonoBehaviour
    {
        public TMP_Text ParkScoreText5;
        public TMP_Text ParkQnText5;

        void Start()
        {
            ParkScoreText5.text = ChangeTxt.ChangeTMPText.score15;
            ParkQnText5.text = ChangeTxt.ChangeTMPText.qn51;
        }

        void Update()
        {
            if (ParkClick5.ItemsClicked == 1)
            {
                ParkScoreText5.text = ChangeTxt.ChangeTMPText.score16;
            }
        }
    }
}