using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameControlK3 : MonoBehaviour
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
        if (KitchenClick3.ItemsClicked >= 3)
        {
            youWin.SetActive(true);
        }
    }
}
