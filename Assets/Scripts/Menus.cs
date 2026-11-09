using UnityEngine;
using UnityEngine.InputSystem;
using UnityEngine.SceneManagement;

public class Menus : MonoBehaviour
{
    public GameObject startPanel;
    public GameObject pausePanel;
    public GameObject winPanel;
    public GameObject losePanel;
    bool paused = false;

    void Start()
    {
        // The game opens on the start screen
        startPanel.SetActive(true);
        SetMenuOpen(true);
    }
    void Update()
    {
        // Quits the game only if the escape button is pressed in the start menu 
        if (startPanel.activeSelf && Keyboard.current.escapeKey.wasPressedThisFrame)
        {
            QuitGame();
        }
        else if (winPanel.activeSelf && Keyboard.current.escapeKey.wasPressedThisFrame)
        {
            QuitGame();
        }
        else if (winPanel.activeSelf && Keyboard.current.enterKey.wasPressedThisFrame)
        {
            RestartGame();
        }
        else if (losePanel.activeSelf && Keyboard.current.enterKey.wasPressedThisFrame)
        {
            RestartGame();
        }
        else if (losePanel.activeSelf && Keyboard.current.escapeKey.wasPressedThisFrame)
        {
            QuitGame();
        }
        else if (Keyboard.current.escapeKey.wasPressedThisFrame)
        {
            paused = !paused;
            pausePanel.SetActive(paused);
            SetMenuOpen(paused);
        }

        // Start game with Enter (if the start panel is active)
        if (startPanel.activeSelf && Keyboard.current.enterKey.wasPressedThisFrame)
        {
            StartGame();
        }
    }
    // The Play button will call this.
    public void StartGame()
    {
        Debug.Log("Started game");
        startPanel.SetActive(false);
        SetMenuOpen(false);
    }

    public void WinGame()
    {
        Debug.Log("You win");
        winPanel.SetActive(true);
        SetMenuOpen(true);
    }

    public void LoseGame()
    {
        Debug.Log("You lose");
        losePanel.SetActive(true);
        SetMenuOpen(true);
    }

    public void RestartGame()
    {
        Debug.Log("Restart");
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }

    // Toggles the menu on/off
    void SetMenuOpen(bool open)
    {
        if (open)
        {
            Time.timeScale = 0;
        }
        else
        {
            Time.timeScale = 1;
        }
    }
    // Called by the button in the Pause menu
    public void Resume()
    {
        paused = false;
        pausePanel.SetActive(false);
        SetMenuOpen(false);
    }

    public void QuitGame()
    {
        // Quits the game but only stops play mode in the editor
#if UNITY_EDITOR
        UnityEditor.EditorApplication.isPlaying = false;
#else
        Application.Quit();
#endif
    }
}

