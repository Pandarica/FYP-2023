using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine. SceneManagement;

public class UIButtons : MonoBehaviour
{ 
    public void EnterLevelSelection ()
    {
        SceneManager.LoadScene(1);
    }

    public void EnterHome ()
    {
        SceneManager.LoadScene(0);
    }
}
