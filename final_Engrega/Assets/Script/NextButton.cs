using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class NextButton : MonoBehaviour
{
    private Text tutorial2;
    private Text tutorial1;
    private Image imgcontrols;
    private Canvas canvas; // El game object que posee el canvas del tutorial
    private contrller generators;
    private ScoreCounter time;
    bool closeCanvas = false;  // dependiendo de este booleano empieza el juego
    private void Start()
    {
        tutorial2 = GameObject.Find("2Tutorial").GetComponent<Text>();
        tutorial1 = GameObject.Find("1Tutorial").GetComponent<Text>();
        imgcontrols = GameObject.Find("imgControls").GetComponent<Image>();

        canvas = GameObject.Find("Tutorial").GetComponent<Canvas>();
        generators = GameObject.Find("Generadores").GetComponent<contrller>();
        time = GameObject.Find("ExternalControl").GetComponent<ScoreCounter>();
    }
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "pelota")
        {
            if (!closeCanvas)
            {
                tutorial2.enabled = true;
                tutorial1.enabled = false;
                imgcontrols.enabled = false;
                StartCoroutine(OutTutorial());
                closeCanvas = true;
            }
            else {
                generators.active = true;
                time.gameOn(); //inicia la cuenta regresiva
                canvas.enabled = false; // se cierra el tutorial he inicia el juego
                gameObject.SetActive(false);
            }
        }
    }

    IEnumerator OutTutorial() {
        yield return new WaitForSeconds(3f);
        closeCanvas = true;
    }
}