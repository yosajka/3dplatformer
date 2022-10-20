using UnityEngine;
using UnityEngine.UI;

public class GemSilver : MonoBehaviour
{
    public GameObject scoreBox;
    public AudioSource gemCollect;
    public int scoreValue = 1000;

    private void OnTriggerEnter()
    {
        GameManager.Instance.AddScore(scoreValue);
        scoreBox.GetComponent<Text>().text = GameManager.Instance.currentScore.ToString();
        gemCollect.Play();
        Destroy(gameObject);
    }
}
