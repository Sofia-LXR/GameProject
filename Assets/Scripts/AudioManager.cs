using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AudioManager : MonoBehaviour
{
    private static AudioManager instance;//shuxing 

    public static AudioManager Instance
    {
        get
        {
            return instance;
        }
    }
    private void Awake()
    {
        if (instance == null)
        {
            instance = this;
        }
        else
        {
            Destroy(gameObject);
        }
    }

    //在指定位置播放音频 PlayClipAtPoint()
    public AudioClip  PlayAudio(string name)
    {
        AudioClip clip = Resources.Load<AudioClip>("Audio/" + name);
        return clip;
        //Debug.Log("播放音乐");
    }
}
