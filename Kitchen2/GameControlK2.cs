using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameControlK2 : MonoBehaviour
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
        if (KitchenClick2.ItemsClicked >= 4)
        {
            youWin.SetActive(true);
        }
    }
}
