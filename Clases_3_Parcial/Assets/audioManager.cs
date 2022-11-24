using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public enum AudioClips_Soundtracks
{
    NONE,
    Songs_3,
    Songs_2,
}

public enum AundioClips_SFX
{
    NONE,
    Boing,
    Punch,
    Arrstre,
    Metal,
}
public class audioManager : MonoBehaviour
{
    public static audioManager instance;

    public AudioSource audioSource; // Background Music/ Sountrack /Song
    public AudioSource audioSourceEffectRef;

    public AudioClip[] audioClipsSoundtrack;
    public AudioClip[] audioClipsVFX;

    public float SoundtrackVolume = 1.0f;

    // Start is called before the first frame update

    private void Awake()
    {
        if (instance != null)
        {
            return;
        }
        else
        {
            instance = this;
        }
    }

    public void SetAudioClipSpuntrack(AudioClips_Soundtracks audioClip_Sountrack)
    {
        audioSource.Stop();
        audioSource.PlayDelayed(0.3f);
        audioSource.PlayOneShot(audioClipsSoundtrack[(int)audioClip_Sountrack], SoundtrackVolume);
    }
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
