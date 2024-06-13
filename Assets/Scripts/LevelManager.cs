using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LevelManager : MonoBehaviour
{
    [SerializeField] float loadDelay = 1f;
    Score score;

    void Awake()
    {
          score = FindObjectOfType<Score>();
    }

   public void LoadGame()
   {
        //score.ResetScore();
        SceneManager.LoadScene("Game");
   }

   public void LoadMainMenu()
   {
        SceneManager.LoadScene(0);
   }

   public void LoadGameOver()
   {
        StartCoroutine(WaitAndLoad("GameOver", loadDelay));
   }

   public void QuitGame()
   {
        Application.Quit();
   }

   IEnumerator WaitAndLoad(string sceneName, float delay)
   {
        yield return new WaitForSeconds(delay);
        SceneManager.LoadScene(sceneName);
   }
}
