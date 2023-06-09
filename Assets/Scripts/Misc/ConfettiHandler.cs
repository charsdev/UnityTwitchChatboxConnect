using System.Collections.Generic;
using UnityEngine;

public class ConfettiHandler : MonoBehaviour
{
    public List<ParticleSystem> Conffetties = new List<ParticleSystem>();
    public AudioClip AudioClip;
    public AudioSource AudioSource;

    public void ShowConfetti()
    {
        foreach (ParticleSystem p in Conffetties)
        {
            p.Play();
        }

        AudioSource.PlayOneShot(AudioClip);
    }
}
