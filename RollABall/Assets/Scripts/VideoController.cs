using UnityEngine;
using UnityEngine.Video;

public class VideoController : MonoBehaviour
{
    
    public VideoPlayer myVideo;
    
    public void StopVideo(){
        myVideo.Pause();
    }

    public void PlayVideo(){
        myVideo.Play();
    }
}
