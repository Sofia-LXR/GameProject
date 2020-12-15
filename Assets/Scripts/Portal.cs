using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Portal : MonoBehaviour
{
    public GameObject Canvas;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Player")
        {
            Canvas.SetActive(true);
            AudioSource source = this.GetComponent<AudioSource>();
            source.clip=AudioManager.Instance.PlayAudio("Audio001");//返回一个clip
            source.Play();
        }
         

    }
}
