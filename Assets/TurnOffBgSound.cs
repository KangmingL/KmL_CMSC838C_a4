using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TurnOffBgSound : MonoBehaviour
{
    // Start is called before the first frame update
    AudioSource backgroundAudio;
    bool isPlaying;
    void Start()
    {
        isPlaying = true;
        backgroundAudio = GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.B)){
            //isPlaying = !isPlaying;
            if(isPlaying){
                backgroundAudio.Stop();
                isPlaying = false;
            }else{
                backgroundAudio.Play();
                isPlaying = true;
            }
        }
    }
}
