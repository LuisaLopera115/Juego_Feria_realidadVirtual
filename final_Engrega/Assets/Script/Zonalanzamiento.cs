using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Zonalanzamiento : MonoBehaviour
{
    public GameObject panel;
    
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "Player") Fade(true);
    }
    private void OnCollisionExit(Collision collision)
    {
        if (collision.gameObject.tag == "Player") Fade(false);
    }

    void Fade(bool faded) {
        CanvasGroup panelfade = panel.GetComponent<CanvasGroup>();

        if (faded)
        {
            panelfade.alpha = 1;
        }
        else {
            panelfade.alpha = 0;
        }
       
    }

    
}
