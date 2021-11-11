using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class contrller : MonoBehaviour
{
    public bool active = false;
    Generation_target[] childrens = new Generation_target[6];
    void Start()
    {
        childrens[0] = GetComponentsInChildren<Generation_target>()[0];
        childrens[1] = GetComponentsInChildren<Generation_target>()[1];
        childrens[2] = GetComponentsInChildren<Generation_target>()[2];
        childrens[3] = GetComponentsInChildren<Generation_target>()[3];
        childrens[4] = GetComponentsInChildren<Generation_target>()[4];
        childrens[5] = GetComponentsInChildren<Generation_target>()[5];
    }

    void Update()
    {
        if (active) 
        {
            childrens[0].activate = true;
            childrens[1].activate = true;
            childrens[2].activate = true;
            childrens[3].activate = true;
            childrens[4].activate = true;
            childrens[5].activate = true;
        } 
        else
        {
            childrens[0].activate = false;
            childrens[1].activate = false;
            childrens[2].activate = false;
            childrens[3].activate = false;
            childrens[4].activate = false;
            childrens[5].activate = false;
        } 
    }
}
