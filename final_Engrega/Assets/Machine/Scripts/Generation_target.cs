using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Generation_target : MonoBehaviour
{
    [SerializeField] GameObject[] targets;
    float timer = 0f, cont = 0f; 
    [SerializeField]float inter;
    int mouns = 1;
    public bool activate = false;

    void Start()
    {
        
    }

    
    void Update()
    {
        if (activate) timer += Time.deltaTime;
        if (timer > cont + inter)
        {
            mouns = Random.Range(0, 4);
            Generation(mouns);
            cont = timer;
            mouns++;
            if (mouns == 4) mouns = 0;
        }
    }

    void Generation(int mon) 
    {
        Instantiate(targets[mon], transform.position, Quaternion.identity);
    }


}
