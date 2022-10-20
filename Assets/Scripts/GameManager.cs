using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    public static GameManager Instance { get; private set; }

    public int currentScore { get; private set; }
    
    public int currentLevel = 1;
    public int maxLevel = 2;

    private void Awake()
    {
        if (Instance != null)
        {
            DestroyImmediate(gameObject);
        }
        else
        {
            Instance = this;

            DontDestroyOnLoad(gameObject);
        }
    }

    private void Start()
    {
        Application.targetFrameRate = 120;

        NewGame();
    }

    private void OnDestroy()
    {
        if (Instance == this)
        {
            Instance = null;
        }
    }

    private void NewGame()
    {
        SceneManager.LoadScene("MainMenu");
    }

    public void AddScore(int value)
    {
        currentScore += value;
    }

    public int CalculateScore(int timeLeft)
    {
        return timeLeft * 100 + currentScore;
    }

    
}
