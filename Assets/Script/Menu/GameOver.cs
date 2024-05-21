using UnityEngine;
using UnityEngine.SceneManagement;
using System.Collections;


public class TrapScript : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Player"))
        {
            GameOverManagement.Instance.GameOver();
        }
    }
}

public class GameOverManagement : MonoBehaviour
{
    public static GameOverManagement Instance;  

    public GameObject gameOverScreen;
    public float delayBeforeRestart = 3f;

    void Awake()
    {
        if (Instance == null)
        {
            Instance = this;
        }
        else
        {
            Destroy(gameObject);
        }
    }

    void Start()
    {
        gameOverScreen.SetActive(false);
    }

    public void GameOver()
    {
        gameOverScreen.SetActive(true);

        StartCoroutine(RestartLevel());
    }

    IEnumerator RestartLevel()
    {
        yield return new WaitForSeconds(delayBeforeRestart);

        Scene currentScene = SceneManager.GetActiveScene();
        SceneManager.LoadScene(currentScene.buildIndex);
    }
}

