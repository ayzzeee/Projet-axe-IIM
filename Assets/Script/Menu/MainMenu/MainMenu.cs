using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{
    public void PlayGame()
    {
        // Ajoutez des messages de débogage pour vérifier si la méthode est appelée
        Debug.Log("PlayGame() method called");

        // Vérifiez si vous avez des scènes dans votre build settings
        if (SceneManager.sceneCountInBuildSettings > SceneManager.GetActiveScene().buildIndex + 1)
        {
            // Chargez la scène suivante dans la liste des scènes du build
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
        }
        else
        {
            // Ajoutez un message d'erreur si vous atteignez la fin de la liste des scènes
            Debug.LogError("No next scene available. Check your build settings.");
        }
    }

    public void QuitGame()
    {
        // Ajoutez des messages de débogage pour vérifier si la méthode est appelée
        Debug.Log("QuitGame() method called");

        // Quitte l'application dans l'éditeur Unity, mais pas dans une build autonome
        Application.Quit();
    }
}
