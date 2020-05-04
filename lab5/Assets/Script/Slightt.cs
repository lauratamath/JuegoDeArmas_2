using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Slightt : MonoBehaviour
{
    public Text scoreText;
    private int score = 0;
    private AudioSource shotSFX;
    // Start is called before the first frame update
    void Start()
    {
        shotSFX = GetComponent<AudioSource>();   
    }

    // Update is called once per frame
    void Update()
    {
        if (scoreText)
            scoreText.text = "dead virus: " + score.ToString() + "/4";

        if (Input.GetMouseButtonDown(0))
        {
            Ray myRay = Camera.main.ScreenPointToRay(Input.mousePosition);
            RaycastHit hitInfo;

            if (Physics.Raycast(myRay, out hitInfo))
            {
                if (hitInfo.collider.CompareTag("Destroy"))
                {
                    if (shotSFX) shotSFX.Play();
                    Destroy(hitInfo.collider.gameObject);
                    score++;
                }
            }
                

        }

    }
}
