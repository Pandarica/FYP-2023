using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using ChangeTxt;
using KtCk5;

namespace KtTxt5
{
    public class KitchenText5 : MonoBehaviour
    {
        public TMP_Text KitchenScoreText5;
        public TMP_Text KitchenQnText5;


        public string hint1 = "Click on the buildings";
        public string hint2 = "Click on the grass";
        public string hint3 = "Click on the sky";
        public string hint4 = "Click on the tree";
        public string hint5 = "Click on the birds";

        void Start()
        {
            KitchenScoreText5.text = ChangeTxt.ChangeTMPText.score15;
            KitchenQnText5.text = ChangeTxt.ChangeTMPText.qn51;
        }

        void Update()
        {
            if (KtCk5.KitchenClick5.ItemsClicked == 1)
            {
                KitchenScoreText5.text = ChangeTxt.ChangeTMPText.score16;
            }
        }
    }
}

