using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameControlK4 : MonoBehaviour
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
        if (KitchenClick4.ItemsClicked >= 2)
        {
            youWin.SetActive(true);
        }
    }
}
