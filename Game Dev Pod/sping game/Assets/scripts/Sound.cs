using UnityEngine;
using UnityEngine.Audio;

[System.Serializable]
public class Sound 
{
    // make a public var of type string called "soundName"
    public string soundName;

    // Create a public variable of type AudioClip called "audioClip"
    public AudioClip audioClip;

    // Create public variable of type float called "volume"
    [Range(.1f, 1f)]
    public float volume;
    
    // Create a public variable of type float called "pitch"
    [Range(.1f, 3f)]
    public float pitch;

    // Create a public variable of type bool called "loop"
    public bool loop;
    
    // Create a public variable of type AudioSource called "audioSource"
    [HideInInspector]
     public AudioSource audioSource;
}   
    


