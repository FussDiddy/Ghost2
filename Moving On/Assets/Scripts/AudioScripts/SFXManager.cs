using UnityEngine.Audio;
using System;
using UnityEngine;

public class SFXManager : MonoBehaviour
{
    public Sound[] sounds;

    public static SFXManager instance;

    public AudioMixerGroup group;

    // Start is called before the first frame update
    void Awake ()
    {


        foreach (Sound sound in sounds)
        {
            sound.source = gameObject.AddComponent<AudioSource>();
            sound.source.clip = sound.clip;
            
            sound.source.volume = sound.volume;
            sound.source.pitch = sound.pitch;

            sound.source.loop = sound.loop;
        }

    }

    public void Play (string name)
    {
        Sound s = Array.Find(sounds, sound => sound.name == name);
        s.source.Play();
    }

}
