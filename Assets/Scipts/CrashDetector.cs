using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class CrashDetector : MonoBehaviour
{
    [SerializeField] float loadDelay = .8f;
    [SerializeField] ParticleSystem crashEffect;
    [SerializeField] AudioClip crashSFX;
    bool hasCrashed = false;
    void OnTriggerEnter2D(Collider2D other) {
        if(other.tag =="ground" && !hasCrashed){
            hasCrashed = true;
            FindObjectOfType<PlayerController>().DisableControls();
            crashEffect.Play();
            GetComponent<AudioSource>().PlayOneShot(crashSFX);
            Invoke("ReloadScene", loadDelay);
        }
   }
   void  ReloadScene(){
         Debug.Log("head crash");
            SceneManager.LoadScene(0);
    }
}
