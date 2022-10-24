using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuManager : MonoBehaviour
{
    private void Start()
    {
        Cursor.visible = true;
        Cursor.lockState = CursorLockMode.None;
    }
    public void PlayGame()
    {
        SceneManager.LoadScene(1);
    }

    public void GameOver()
    {
        SceneManager.LoadScene(2);
    }

    public void Menu()
    {
        SceneManager.LoadScene(0);
    }
}
