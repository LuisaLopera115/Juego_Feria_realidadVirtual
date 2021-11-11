using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Controller_target : MonoBehaviour
{
    
    [SerializeField] float velocidad;
    Vector3 pose;
    Transform rg;
    void Start()
    {
        pose = transform.position;
        rg = gameObject.GetComponent<Transform>();
        rg.rotation = Quaternion.Euler(0, 180, 0);
    }

   
    void Update()
    {
        
        pose.x += velocidad * Time.deltaTime;
        transform.position = pose;
        //transform.rotation = new Quaternion(0, 180, 0,0);
    }

    private void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.tag == "Destructor")
        {
            Destroy(gameObject);
        }
    }
}
