using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HandPrintDoor : MonoBehaviour
{
    [Header("TAGS")]
    
    public string HandTag;
    [Header("GAMEOBJECTS")]

    public GameObject Button;
    public GameObject Door;
    [Header("MATERIALS")]
    
    public Material Red;
    public Material Green;
    [Header("DELAY")]
    public float Delay;

    [Header("SOUNDS")]
    public AudioSource OpenSound;
    public AudioSource CloseSound;
    
    void OnTriggerEnter(Collider other)
    {
        if (other.tag == HandTag)
        
        {
            Door.SetActive(false);
            Button.GetComponent<Renderer>().material = Green;
            OpenSound.Play();
            {
                StartCoroutine(DelayedAction(Delay));
            }
            IEnumerator DelayedAction(float delayInSeconds)
            {
                yield return new WaitForSeconds(delayInSeconds);
                {
                    Door.SetActive(true);
                    Button.GetComponent<Renderer>().material = Red;
                    CloseSound.Play();
                }


            }
        }
    }
}
