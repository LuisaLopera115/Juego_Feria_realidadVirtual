using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Suelo : MonoBehaviour
{
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "pelota")
        {
            Destroy(collision.gameObject);
            Debug.Log("enttra al condional");
        }
    }
}
