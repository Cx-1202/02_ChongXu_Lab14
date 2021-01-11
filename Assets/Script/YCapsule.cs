using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class YCapsule : MonoBehaviour
{
    public GameObject YellowText;
    private int YellowCounter;

    private AudioSource YellowSound;
    // Start is called before the first frame update
    void Start()
    {
        YellowSound = GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {

    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Player")
        {
            YellowCounter++;
            YellowText.GetComponent<Text>().text = "Yellow: " + YellowCounter;
            YellowSound.Play();
        }
    }
}

