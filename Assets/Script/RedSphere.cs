using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class RedSphere : MonoBehaviour
{
    public GameObject RedText;
    private int redCounter;

    private AudioSource audioSourcesss;
    // Start is called before the first frame update
    void Start()
    {
        audioSourcesss = GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.tag == "Player")
        {
            redCounter++;
            RedText.GetComponent<Text>().text = "Red: " + redCounter;
            audioSourcesss.Play();
        }
    }
}
