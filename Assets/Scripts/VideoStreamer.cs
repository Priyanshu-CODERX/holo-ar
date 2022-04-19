using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Networking;
using UnityEngine.Video;
using TMPro;

public class VideoStreamer : MonoBehaviour
{
    public TMP_InputField urlInput;
    public VideoPlayer[] videoPlayer;

    public void DownloadVideo()
    {
        for(int i = 0; i<videoPlayer.Length; i++)
        {
            videoPlayer[i].url = urlInput.text;
            videoPlayer[i].isLooping = true;
            videoPlayer[i].renderMode = UnityEngine.Video.VideoRenderMode.MaterialOverride;
            videoPlayer[i].targetMaterialRenderer = GetComponent<Renderer>();
            videoPlayer[i].targetMaterialProperty = "_BaseMap";
            videoPlayer[i].Play();
        }
    }
}
