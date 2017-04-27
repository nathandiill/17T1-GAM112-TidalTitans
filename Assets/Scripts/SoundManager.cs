using UnityEngine;
using System.Collections;

public class SoundManager : MonoBehaviour
{
    public static SoundManager Instance;

    void Awake()
    {
        Instance = this;
    }

    public AudioClip[] EventSounds;
    public AudioSource SFXChannel;

    // To call when blue key audio is needed
    public void kingCrabAudio()
    {
        AudioClip KingCrab = EventSounds[0];
        SFXChannel.PlayOneShot(KingCrab);
    }

    // To call when red key audio is needed
    public void LeoAudio()
    {
        AudioClip Leo = EventSounds[1];
        SFXChannel.PlayOneShot(Leo);
    }

    // To call when yellow key audio is needed
    public void SparkyAudio()
    {
        AudioClip Sparky = EventSounds[2];
        SFXChannel.PlayOneShot(Sparky);
    }

    // To call when speed audio is needed
    public void SwashAudio()
    {
        AudioClip Swash = EventSounds[3];
        SFXChannel.PlayOneShot(Swash);
    }

    // To call when XP audio is needed
    public void FidgetAudio()
    {
        AudioClip Fidget = EventSounds[4];
        SFXChannel.PlayOneShot(Fidget);
    }

  
}
