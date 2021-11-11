using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Move_target : MonoBehaviour
{
    [SerializeField] AnimationCurve highing;
    [SerializeField] float timer = 6;
    float t = 0, high = 0.178f;
    Vector3 pos, initial;
    Transform rg;

    void Start()
    {
        initial = transform.position;
        pos = transform.position;
        rg = gameObject.GetComponent<Transform>();
        rg.rotation = Quaternion.Euler(0, 180, 0);
    }


    void Update()
    {
        pos.y = Mathf.Lerp(initial.y, initial.y + high, highing.Evaluate(t / timer));

        t += Time.deltaTime;
        transform.position = pos;
        //transform.rotation = new Quaternion(0, 0, 0, 0);
        if (t > timer + 0.5f) Destroy(gameObject);
    }
}
