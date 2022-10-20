using UnityEngine;
using System.Collections;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class FinishLevel : MonoBehaviour
{
    public GameObject levelMusic;
    public GameObject timer;
    public AudioSource levelCompleteSound;
    public GameObject timeLeft;
    public GameObject score;
    public GameObject finalScore;
    public GameObject blocker;
    

    private void OnTriggerEnter()
    {
        blocker.SetActive(true);
        blocker.transform.parent = null;
        GetComponent<BoxCollider>().enabled = false;
        levelMusic.SetActive(false);
        timer.SetActive(false);
        levelCompleteSound.Play();
        
        
        StartCoroutine(DisplayScore());
    }

    private IEnumerator DisplayScore()
    {
        timeLeft.SetActive(true);
        timeLeft.GetComponent<Text>().text = "Time Left: " + GlobalTimer.remainingTime.ToString() + " x 100";
        yield return new WaitForSeconds(1f);
        score.SetActive(true);
        score.GetComponent<Text>().text = "Score: " + GameManager.Instance.currentScore.ToString();
        yield return new WaitForSeconds(1f);
        finalScore.SetActive(true);
        int finalScoreValue = GameManager.Instance.CalculateScore(GlobalTimer.remainingTime);

        // Save best score
        if (finalScoreValue > PlayerPrefs.GetInt("LevelScore"))
        {
            PlayerPrefs.SetInt("LevelScore", finalScoreValue);
        }
        
        finalScore.GetComponent<Text>().text = "Final Score: " + finalScoreValue.ToString();
        yield return new WaitForSeconds(1f);

        if (GameManager.Instance.currentLevel < GameManager.Instance.maxLevel)
        {
            GameManager.Instance.currentLevel++;
            SceneManager.LoadScene("Level0" + GameManager.Instance.currentLevel.ToString());
        }
        else
        {
            GameManager.Instance.currentLevel = 1;
            SceneManager.LoadScene("MainMenu");
            
        }
        
    }   
}
