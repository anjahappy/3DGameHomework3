using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class parabola1 : MonoBehaviour
{
    private float v0;
    private float angle;
    private float vx;
    private float vy;
    // Start is called before the first frame update
    void Start()
    {
        angle = Mathf.PI/3;
        v0 = 10;
        vx = v0 * Mathf.Cos(angle);
        vy = v0 * Mathf.Sin(angle);
    }

    // Update is called once per frame
    void Update()
    {
        vy -= 9.8f * Time.deltaTime;
        Vector3 aaa = new Vector3(vx, vy, 0) * Time.deltaTime;
        this.transform.position += aaa;

    }
}
