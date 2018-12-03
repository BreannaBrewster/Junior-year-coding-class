using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;
using Object = UnityEngine.Object;
using System.Linq;

public enum SoundEffect
{
    Music,
    Moosic,
}
public class AudioManager
{
    static AudioManager instance;
    private Dictionary<SoundEffect, AudioClip> SoundEffects
    { get; set; }
    private AudioSource SoundEffectSource
    { get; set; }
    private AudioSource BGMSource
    { get; set; }
    public static AudioManager Instance
    { get { return instance ?? (instance = new AudioManager()); } }
    private AudioManager()
    {
        SoundEffects = Resources.LoadAll<AudioClip>("")
            .ToDictionary(t => (SoundEffect)Enum.Parse(typeof(SoundEffect), t.name, true));
        SoundEffectSource = new GameObject("SoundEffectSource", typeof(AudioSource)).GetComponent<AudioSource>();
        Object.DontDestroyOnLoad(SoundEffectSource.gameObject);

        BGMSource = new GameObject("BMGSource", typeof(AudioSource)).GetComponent<AudioSource>();
        BGMSource.volume = .5f;
        BGMSource.loop = true;
        Object.DontDestroyOnLoad(BGMSource.gameObject);

        //ChangeBGM(Resources.Load<AudioClip>("Sound/Music/DancingMidgets"));
    }
    public void PlayOneShot(SoundEffect sound, float volumeScale = 1)
    {
        SoundEffectSource.PlayOneShot(SoundEffects[sound], volumeScale * 1);
    }
    public void ChangeBGM(AudioClip clip)
    {
        BGMSource.clip = clip;
        BGMSource.Play();
    }
}
