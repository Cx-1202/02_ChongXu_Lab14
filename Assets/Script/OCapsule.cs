using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class OCapsule : MonoBehaviour
{
    public GameObject OrangeText;
    private int OrangeCounter;

    private AudioSource OrangeSound;
    // Start is called before the first frame update
    void Start()
    {
        OrangeSound = GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {

    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Player")
        {
            OrangeCounter++;
            OrangeText.GetComponent<Text>().text = "Orange: " + OrangeCounter;
            OrangeSound.Play();
        }
    }
}
