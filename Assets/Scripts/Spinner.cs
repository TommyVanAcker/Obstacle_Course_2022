using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spinner : MonoBehaviour
{
    [Tooltip("rotationAngle each second")][SerializeField] float rotationAngle = 360f;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Spin();
    }

    private void Spin()
    {
        float rotationPerSecond = rotationAngle * Time.deltaTime;
        transform.Rotate(Vector3.up, rotationPerSecond, Space.Self);
    }
}
