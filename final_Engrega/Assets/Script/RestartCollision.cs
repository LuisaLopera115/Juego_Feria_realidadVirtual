
using UnityEngine;
using UnityEngine.SceneManagement;

public class RestartCollision : MonoBehaviour
{
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag=="pelota")
        {
            SceneManager.LoadScene("FINAL_AR_VR");
        }
    }
}
