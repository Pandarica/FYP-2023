using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine. SceneManagement;

public class Park1Button : MonoBehaviour
{ 
    public void EnterLevelSelection ()
    {
        SceneManager.LoadScene(1);
    }

    public void EnterHome ()
    {
        SceneManager.LoadScene(0);
    }

    public void NextScene ()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }
}
