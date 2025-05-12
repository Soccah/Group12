using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UIElements;
/// <summary>
/// Olivia Foster
/// 5/11/25
/// Manages buttons in the title screen
/// </summary>

public class TitleScreen : MonoBehaviour
{
    public GameObject controlsPanel;
    public GameObject backButton;
    public GameObject titleText;
    public GameObject startGameButton;
    public GameObject quitButton;
    public GameObject controlsButton;

    private void Start()
    {
        controlsPanel.SetActive(false);
        backButton.SetActive(false);
    }
    public void StartGame()
    {
        SceneManager.LoadScene("SampleScene");
    }

    public void ShowControls()
    {
        controlsPanel.SetActive(true);
        backButton.SetActive(true);
        titleText.SetActive(false);
        startGameButton.SetActive(false);
        quitButton.SetActive(false);
        controlsButton.SetActive(false);
    }

    public void HideControls()
    {
        controlsPanel.SetActive(false);
        backButton.SetActive(false);
        titleText.SetActive(true);
        startGameButton.SetActive(true);
        quitButton.SetActive(true);
        controlsButton.SetActive(true);
    }

    public void QuitGame()
    {
        Application.Quit();
    }
}
