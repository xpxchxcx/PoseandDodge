using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    public static bool gameHasEnded = false;

    public float restartDelay = 1f;
    public GameObject gameOverUI;


    private void Awake()
    {
        gameHasEnded = false;
    }
    public void GameOverScreen()
    {
        gameHasEnded = true;
        gameOverUI.SetActive(true);
    }
   public void EndGame ()
    {
        if (gameHasEnded == false)
        {
            gameHasEnded = true;
            Debug.Log("GAME OVER");

            // Restart Game
            GameOverScreen();
            //Invoke("Restart", restartDelay);
        }
    }

    public void Restart()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }
}
