using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{
    public void LoadLevel_1 () {
        SceneManager.LoadScene("Level_1");
    }

    public void LoadSettingsScene () {
        SceneManager.LoadScene("SettingsScene");
    }

    public void LoadMainMenu () {
        SceneManager.LoadScene("MainMenu");
    }

    public void LoadDeathScreen () {
        SceneManager.LoadScene("DeathScreen");
    }

    bool isMute = false;
    public void ToggleMute () {
        if (!isMute)
        {
            AudioListener.volume = 0f;
        }
        else
        {
            AudioListener.volume = 0.3f;
        }
    }

    public void ExitGame () {
    #if UNITY_STANDALONE
        Application.Quit();
    #endif
    #if UNITY_EDITOR
        UnityEditor.EditorApplication.isPlaying = false;
    #endif
    }
}
