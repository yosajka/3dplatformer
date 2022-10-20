using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using System.Collections;

public class MainMenuFunction : MonoBehaviour
{
    public AudioSource clickButtonSound;
    public GameObject fadeOut;

    public GameObject bestScoreUI;
    private int bestScore;

    private void Start()
    {
        bestScore = PlayerPrefs.GetInt("LevelScore");
        bestScoreUI.GetComponent<Text>().text = "Best Score: " + bestScore.ToString();
    }

    public void PlayGame()
    {
        clickButtonSound.Play();
        StartCoroutine(LoadSceneSequence("Level0" + GameManager.Instance.currentLevel));
    }

    private IEnumerator LoadSceneSequence(string sceneName)
    {
        fadeOut.SetActive(true);
        yield return new WaitForSeconds(2f);
        SceneManager.LoadScene(sceneName);
    }

    public void QuitGame()
    {
        clickButtonSound.Play();
        Application.Quit();
    }

    public void Credit()
    {
        clickButtonSound.Play();
        StartCoroutine(LoadSceneSequence("Credits"));
    }

    public void ResetBestScore()
    {
        bestScore = 0;
        PlayerPrefs.SetInt("LevelScore", 0);
        bestScoreUI.GetComponent<Text>().text = "Best Score: " + bestScore.ToString();
    }
}
