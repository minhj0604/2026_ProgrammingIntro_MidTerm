using UnityEngine;

public class SoundManager : MonoBehaviour
{
    public static SoundManager Instance;

    public AudioClip clip;
    AudioSource audioSource;

    void Start()
    {
        Instance = this;

        audioSource = gameObject.AddComponent<AudioSource>();
        audioSource.clip = clip;
    }

    public void PlaySound()
    {
        audioSource.PlayOneShot(clip);
    }
}
