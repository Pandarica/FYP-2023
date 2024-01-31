using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine. SceneManagement;

public class LevelSelection : MonoBehaviour
{
    public void Return ()
    {
        SceneManager.LoadScene(0);
    }

    public void PlayScene1 ()
    {
        SceneManager.LoadScene(2);
    }

    public void PlayScene2 ()
    {
        SceneManager.LoadScene(7);
    }

    public void PlayScene3 ()
    {
        SceneManager.LoadScene(12);
    }
}