using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameControlP5 : MonoBehaviour
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
        if (ParkClick5.ItemsClicked >= 1)
        {
            youWin.SetActive(true);
        }
    }
}
