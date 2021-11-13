
using UnityEngine;

public class RestartCollision : MonoBehaviour
{
    private Canvas Canvas;
    private ScoreCounter StartGame;
    private void Start()
    {
        StartGame = GameObject.Find("ExternalControl").GetComponent<ScoreCounter>();
    }
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag=="pelota")
        {
            StartGame.gameOn();
        }
    }
}
