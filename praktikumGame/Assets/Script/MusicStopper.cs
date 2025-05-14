using UnityEngine;
using UnityEngine.SceneManagement;

public class MusicStopper : MonoBehaviour
{
    private AudioSource audioSource;

    void Start()
    {
        audioSource = GetComponent<AudioSource>();
        SceneManager.sceneLoaded += OnSceneLoaded;
    }

    void OnSceneLoaded(Scene scene, LoadSceneMode mode)
    {
        if (scene.name != "mainmenu") // Ganti dengan nama scene main menu kamu
        {
            audioSource.Stop();
            Destroy(gameObject); // Hapus objek ini agar tidak nyangkut
        }
    }

    void OnDestroy()
    {
        SceneManager.sceneLoaded -= OnSceneLoaded;
    }
}
