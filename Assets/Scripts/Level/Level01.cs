using System.Collections;
using UnityEngine;

public class Level01 : MonoBehaviour
{
    public GameObject fadeIn;
    
    void Start()
    {
        StartCoroutine(FadeInOff());
    }

    private IEnumerator FadeInOff()
    {
        yield return new WaitForSeconds(1f);
        fadeIn.SetActive(false);
    }
}
