using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ButtonActions : MonoBehaviour
{
    public void Quit()
    {
        AudioManager.instance.Play("ButtonPress");
        Application.Quit();
    }

    public void Restart()
    {
        AudioManager.instance.Play("ButtonPress");
        Scene scene = SceneManager.GetActiveScene(); 
        SceneManager.LoadScene(scene.name);
    }

    public void StartGame()
    {
        AudioManager.instance.Play("ButtonPress");
        AudioManager.instance.Play("MainTheme");
        AudioManager.instance.Fade("GameTheme", 20f, 0f);
        AudioManager.instance.Fade("MainTheme", 20f, 0.05f);
        SceneManager.LoadScene(1);
    }
}
