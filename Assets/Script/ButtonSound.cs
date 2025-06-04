using UnityEngine;

public class ButtonSound : MonoBehaviour
{
    public AudioClip clickSound; // assign via Inspector
    private AudioSource audioSource;

    void Start()
    {
        // Cari AudioSource dari GameObject ini atau global
        audioSource = GameObject.Find("ButtonSFX").GetComponent<AudioSource>();
    }

    public void PlayClickSound()
    {
        if (audioSource && clickSound)
            audioSource.PlayOneShot(clickSound);
    }
}
