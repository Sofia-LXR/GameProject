using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Portal : MonoBehaviour
{
    public GameObject Panel;
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
            Panel.SetActive(true);
            AudioSource source = this.GetComponent<AudioSource>();
            source.clip = Resources.Load<AudioClip>("Audio/Audio001");
            source.Play();
        }
         
    }
}
