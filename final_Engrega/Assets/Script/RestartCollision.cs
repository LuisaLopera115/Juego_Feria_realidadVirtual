
using UnityEngine;

public class RestartCollision : MonoBehaviour
{
    private Canvas Canvas;
    private ScoreCounter StartGame;
    private void Start()
    {
        Canvas = GameObject.Find("EndGame").GetComponent<Canvas>();
        StartGame = GameObject.Find("ExternalControl").GetComponent<ScoreCounter>();
    }
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag=="pelota")
        {
            Canvas.enabled = false;
            StartGame.gameOn();
        }
    }
}
