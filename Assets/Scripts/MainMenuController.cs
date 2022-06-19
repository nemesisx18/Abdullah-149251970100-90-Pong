using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenuController : MonoBehaviour
{
    public void PlayGame()
    {
        SceneManager.LoadScene("Game");
        Debug.Log("Created by Abdullah-149251970100-90");
    }

    public void OpenAuthor()
    {
        SceneManager.LoadScene("Credit");
        Debug.Log("Created by Abdullah-149251970100-90");
    }
}
