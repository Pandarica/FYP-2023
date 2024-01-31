using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameControlM3 : MonoBehaviour
{
    [SerializeField]
    private GameObject youWin;

    // Start is called before the first frame update
    void Start()
    {
        youWin.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        if (MarketClick3.ItemsClicked >= 3)
        {
            youWin.SetActive(true);
        }
    }
}
