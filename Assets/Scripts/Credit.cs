using System.Collections;
using UnityEngine.SceneManagement;
using UnityEngine;

public class Credit : MonoBehaviour
{
    
    void Start()
    {
        StartCoroutine(RollCreds());
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.Escape))
        {
            SceneManager.LoadScene("MainMenu");
        }
    }

    private IEnumerator RollCreds()
    {
        //fadeOut.SetActive(true);
        yield return new WaitForSeconds(15f);
        SceneManager.LoadScene("MainMenu");
    }
}
