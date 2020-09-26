using UnityEngine;

public class PlaySound : MonoBehaviour
{
    public AudioSource soundToPlay;
    
    public void PlaySoundEffect()
    {
        soundToPlay.Play();
    }
}
