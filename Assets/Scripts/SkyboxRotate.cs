using UnityEngine;

public class SkyboxRotate : MonoBehaviour
{
    public float rotateSpeed = 2f;

    private void Update()
    {
        RenderSettings.skybox.SetFloat("_Rotation", rotateSpeed * Time.time);
    }
}
