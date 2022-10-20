using UnityEngine;
using UnityEngine.SceneManagement;
using System.Collections;

public class DeathBarrier : MonoBehaviour
{
     public GameObject deathUI;
     public GameObject timer;
     public GameObject levelMusic;
     public AudioSource deathSound;
     public GameObject fadeOut;

     private void OnTriggerEnter()
     {
          StartCoroutine(DeathSequence());    
     }

     private IEnumerator DeathSequence()
     {
          timer.SetActive(false);
          deathUI.SetActive(true);
          levelMusic.SetActive(false);
          deathSound.Play();
          yield return new WaitForSeconds(2f);
          fadeOut.SetActive(true);
          yield return new WaitForSeconds(2f);
          
          SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
     }
}
