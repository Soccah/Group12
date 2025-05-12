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
    public GameObject titleScreenPanel;

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
        titleScreenPanel.SetActive(false);
    }

    public void HideControls()
    {
        controlsPanel.SetActive(false);
        backButton.SetActive(false);
        titleScreenPanel.SetActive(true);
    }

    public void QuitGame()
    {
        Application.Quit();
    }
}
