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
        // Only lets the player use the current buttons on the respectve panel
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

        // Start game with Enter if the start panel is active
        if (startPanel.activeSelf && Keyboard.current.enterKey.wasPressedThisFrame)
        {
            StartGame();
        }
    }

    public void StartGame()
    {
        // Shuts off start screen when starting
        Debug.Log("Started game");
        startPanel.SetActive(false);
        SetMenuOpen(false);
    }

    public void WinGame()
    {
        // Opens win screen
        Debug.Log("You win");
        winPanel.SetActive(true);
        SetMenuOpen(true);
    }

    public void LoseGame()
    {
        // Opens lose screen
        Debug.Log("You lose");
        losePanel.SetActive(true);
        SetMenuOpen(true);
    }

    public void RestartGame()
    {
        // Reloads the scene on restart
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
  

    public void Resume()
    {
        // Unpauses the timer and resumes
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

