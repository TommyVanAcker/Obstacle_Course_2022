using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Scorer : MonoBehaviour
{
    int hits = 0;



    private void OnCollisionEnter(Collision collision)
    {
        hits++;
        Debug.Log("you bumped into something this many times: " + hits);
    }
}
