using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenuButtonBehavior : MonoBehaviour
{
    public void OnMainMenuButtonPressed()
    {
        Time.timeScale = 1;
        SceneManager.LoadScene("MainMenu");
    }
}
