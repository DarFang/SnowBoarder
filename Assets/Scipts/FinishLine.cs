using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class FinishLine : MonoBehaviour
{
    [SerializeField] float loadDelay = 1.5f;
    [SerializeField] ParticleSystem finishEffect;
    bool hasFinished = false;

    void OnTriggerEnter2D(Collider2D other) {
        if(other.tag == "Player" && !hasFinished){
            hasFinished = true;
            finishEffect.Play();
           GetComponent<AudioSource>().Play();
           Invoke("ReloadScene", loadDelay);
        }
    }
    void  ReloadScene(){
         // Debug.Log("finished");
            SceneManager.LoadScene(0);
    }
}
