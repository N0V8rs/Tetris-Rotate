using UnityEngine;
using UnityEngine.Playables;

public class SoundManager : MonoBehaviour
{
    public static SoundManager instance;

    public AudioClip tetrisRotateSound;
    public AudioClip tetrisDropSound;
    public AudioClip tetrisMoveSound;
    public AudioClip tetrisClearSound;
    public AudioClip tetrisGameOverSound;

    private AudioSource audioSource;

    private void Awake()
    {
        if (instance == null)
        {
            instance = this;
            audioSource = GetComponent<AudioSource>();
        }
        else
        {
            Destroy(gameObject);
        }
    }

    public void PlaySound(AudioClip clip)
    {
        if (clip != null)
        {
            audioSource.PlayOneShot(clip);
        }
        else
        {
            Debug.LogWarning("Attempting to play a null audio clip.");
        }
    }

    public void PlayTetrisRotateSound()
    {
        PlaySound(tetrisRotateSound);
    }

    public void PlayTetrisDropSound()
    {
        PlaySound(tetrisDropSound);
    }

    public void PlayTetrisMoveSound()
    {
        PlaySound(tetrisMoveSound);
    }

    public void PlayTetrisClearSound()
    {
        PlaySound(tetrisClearSound);
    }

    public void PlayGameOverSound()
    {
        PlaySound(tetrisGameOverSound);
    }
}


