using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Mover : MonoBehaviour
{
    [SerializeField] float xSpeed = 0.01f;
    [SerializeField] float zSpeed = 0.01f;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(xSpeed, 0f, zSpeed);
    }
}