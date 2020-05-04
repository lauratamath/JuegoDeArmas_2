using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cam : MonoBehaviour
{
    public GameObject reproducer;
    private AudioSource walkSFX;
    // Start is called before the first frame update
    void Start()
    {
        if (reproducer)
            walkSFX = reproducer.GetComponent<AudioSource>();
            reproducer.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetAxis("Horizontal") != 0 || Input.GetAxis("Vertical") !=0)
        {
            WalkSound();
        }
        else
        {
            if (reproducer && reproducer.activeSelf)
                reproducer.SetActive(false);
        }
            
    }

    private void WalkSound()
    {
        if (reproducer && !reproducer.activeSelf)
        {
            reproducer.SetActive(true);
        }
    }
}
