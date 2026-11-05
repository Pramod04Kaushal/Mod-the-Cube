using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cube : MonoBehaviour
{
    public MeshRenderer Renderer;
    
    void Start()
    {
        transform.position = new Vector3(3, 4, 1);
        transform.localScale = Vector3.one + Vector3.one * 1.0f;



    }
    
    void Update()
    {
        transform.Rotate(10.0f * Time.deltaTime, 0.0f, 0.0f);

        if (transform.localScale.x < 5.5)
        {
            transform.localScale = new Vector3(transform.localScale.x, transform.localScale.y, transform.localScale.z) + Vector3.one * Time.deltaTime;
        }
        else if (transform.localScale.x >= 5.5f)
        {
            transform.localScale = Vector3.one;

            Material material = Renderer.material;
            material.color = new Color(Random.Range(0.0f, 1.0f), Random.Range(0.0f, 1.0f), Random.Range(0.0f, 1.0f), Random.Range(0.2f, 1.0f));
        }

    }
}
