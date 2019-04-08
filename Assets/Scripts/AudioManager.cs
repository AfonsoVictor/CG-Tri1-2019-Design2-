using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AudioManager : MonoBehaviour
{
    public AudioSFX audioSFX;
    public static AudioManager instance;
    void Awake (){
        if (instance == null){
            instance = this;
        }
    }

    public void PlaySoundCoinPickup(GameObject obj){
        AudioSource.PlayClipAtPoint(audioSFX.coinPickup, obj.transform.position);
    }
}
