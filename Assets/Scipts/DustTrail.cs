using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DustTrail : MonoBehaviour
{
    [SerializeField] ParticleSystem dustParticles;
    [SerializeField] AudioClip dustSound;
    [SerializeField] AudioSource audioSource;
    private void OnCollisionEnter2D(Collision2D other) {
        if(other.gameObject.tag=="ground"){
            dustParticles.Play();
            audioSource.clip = dustSound;
            audioSource.Play();
        }
    }
    private void OnCollisionExit2D(Collision2D other) {
        if(other.gameObject.tag=="ground"){
            dustParticles.Stop();
            audioSource.Stop();
        }
    }
}
