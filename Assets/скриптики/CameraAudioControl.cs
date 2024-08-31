using UnityEngine;

public class CameraAudioControl : MonoBehaviour
{
    [SerializeField] private AudioSource audioCamera;

    private void OnEnable()
    {
        audioCamera.Play();
    }
    private void OnDisable()
    {
        audioCamera.Stop();
    }
}
