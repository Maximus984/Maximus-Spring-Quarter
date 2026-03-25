using UnityEngine;
using System;

public class AudioManager : MonoBehaviour
{
    // Creat a new  public var of type AudioManager called "Instance"
    public AudioManager Instance {get; private set;}

    // Create a public array of type "Sound" called "sounds"
    public Sound[] sounds;

    // Create a new private function that returns void called "Awake"
    private  void Awake() 
    {
        // Check if "Instance" equals "null"
        if (Instance == null)
        {
            // Assign the "Instance" var to "this"
            Instance = this;
        }
        else
        {
            // Call the "Destroy()" funcation, with "this" as the argument
            Destroy(this);
        }

        // create a "foreach" loop to loop through every sound in our sounds array
        foreach (Sound s in sounds)
        {
            // Configure that sound

            s.audioSource = gameObject.AddComponent<AudioSource>();
            s.audioSource.clip = s.audioClip;
            s.audioSource.volume = s.volume;
            s.audioSource.pitch = s.pitch;
            s.audioSource.loop = s.loop;
        }
    } 

    private void Start()
    {
        // Play the musuc
        PlaySound("music");
    }


    // Create a new public function that returns "void" called "PlaySound(string name)"
    public void PlaySound (string name)
    {
        // Find the sound in the sounds array
        Sound sound = Array.Find(sounds, sound => sound.soundName == name);

        if (sound == null)
        {
            Debug.LogWarning("Did not find song!");
            return;
        }

        // Play the sound
        sound.audioSource.Play();
    }

     public void StopSound (string name)
    {
        // Find the sound in the sounds array
        Sound sound = Array.Find(sounds, sound => sound.soundName == name);

        if (sound == null)
        {
            Debug.LogWarning("Did not find song!");
            return;
        }

        // Play the sound
        sound.audioSource.Stop();
    }
}
