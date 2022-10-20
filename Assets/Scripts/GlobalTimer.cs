using System.Collections;
using UnityEngine;
using UnityEngine.UI;

public class GlobalTimer : MonoBehaviour
{
    public GameObject displayTimer01;
    public GameObject displayTimer02;
    private bool isTakingTime = false;
    public static int remainingTime = 150;

    void Update()
    {
        if (!isTakingTime)
        {
            StartCoroutine(Countdown());
        }

        if (remainingTime == 0)
        {
            // TODO
        }
    }

    private IEnumerator Countdown()
    {
        isTakingTime = true;
        remainingTime -= 1;
        displayTimer01.GetComponent<Text>().text = remainingTime.ToString();
        displayTimer02.GetComponent<Text>().text = remainingTime.ToString();
        yield return new WaitForSeconds(1);
        isTakingTime = false;
    }
}
