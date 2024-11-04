using UnityEngine;

public class CameraAudioControl : MonoBehaviour
{
    [SerializeField] private AudioSource audioCamera;

    private void OnEnable()
    {
        audioCamera = GetComponent<AudioSource>();
        audioCamera.Play();
    }
    private void OnDisable()
    {
        audioCamera = GetComponent<AudioSource>();
        audioCamera.Stop();
    }
}
