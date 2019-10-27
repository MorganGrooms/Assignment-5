using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class scenes : MonoBehaviour
{
    public void PlayAgain()
    {
        SceneManager.LoadScene("Intro");
    }

    public void StartPlay()
    {
        SceneManager.LoadScene("SampleScene");
    }
    public void StopPlaying()
    {
        SceneManager.LoadScene("Exit");
    }



    // Update is called once per frame
    public void ExitGame()
    {
        UnityEditor.EditorApplication.isPlaying = false;
    }
}
