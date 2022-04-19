using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Video;

[RequireComponent(typeof(VideoPlayer))]
public class VideoAutoScale : MonoBehaviour
{

    Vector3 initialScale;

    void Start() {
        initialScale = gameObject.transform.localScale;

        VideoPlayer vPlayer = GetComponent<VideoPlayer>();
        float playerWidth = vPlayer.clip.width;
        float playerHeight = vPlayer.clip.height;

        Vector3 tempScale = initialScale;


        if(playerWidth>playerHeight) {
            float aspRatio = playerHeight/playerWidth;
            tempScale.y = initialScale.x * aspRatio;
        }
        else {
            float aspRatio = playerWidth/playerHeight;
            tempScale.x = initialScale.y * aspRatio;
        }

        gameObject.transform.localScale = tempScale;

    }

}