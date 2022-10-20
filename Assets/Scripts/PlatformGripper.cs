using UnityEngine;

public class PlatformGripper : MonoBehaviour
{
   public GameObject player;
   public GameObject platform;

   private void OnTriggerEnter()
   {
        player.transform.parent = platform.transform;
   }

   private void OnTriggerExit()
   {
        player.transform.parent = null;
   }
}
