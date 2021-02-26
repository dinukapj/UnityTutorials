using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TriggerZone : MonoBehaviour
{
    public AudioSource audio;
    public AudioClip soundForEntering;
    public AudioClip soundForExiting;

    public bool enteredTrigger;

    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(enteredTrigger == true)
        {
            Debug.Log("ITS TRUE!!");
        }
        if (enteredTrigger == false)
        {
            Debug.Log("ITS NOT TRUE!!");
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        enteredTrigger = true;

        audio.clip = soundForEntering;
        audio.Play();
    }

    private void OnTriggerExit(Collider other)
    {
        enteredTrigger = false;

        audio.clip = soundForExiting;
        audio.Play();
    }

}
