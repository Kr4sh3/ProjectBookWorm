using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraController : MonoBehaviour
{
    public Vector3 target;
    public float interpolatation;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        transform.position = Vector3.Lerp(transform.position, target, interpolatation * Time.deltaTime);
    }

    public void SetTargetPosition(Vector3 position)
    {
        target = position;
    }
}
