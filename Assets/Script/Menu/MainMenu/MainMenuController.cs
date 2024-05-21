using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI; 

public class MainMenuController : MonoBehaviour
{
    public CanvasGroup optionPanel;

    // Appelé lorsque le bouton "Start" est cliqué
    public void PlayGame()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }

    // Appelé lorsque le bouton "Quitter" est cliqué
    public void QuitGame()
    {
        Application.Quit();
    }

    void Start()
    {
        optionPanel.alpha = 0;
        optionPanel.blocksRaycasts = false;
    }

    // Update is called once per frame
    void Update()
    {
        // Ajoutez des actions d'update si nécessaire
    }
}
