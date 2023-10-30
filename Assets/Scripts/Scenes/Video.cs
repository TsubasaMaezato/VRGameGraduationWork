using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Video;

public class Video : MonoBehaviour
{
    public VideoPlayer videoPlayer;

    // Start is called before the first frame update
    void Start()
    {
        videoPlayer.Play();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void Vide()
    {
        videoPlayer.Stop();
    }
}
