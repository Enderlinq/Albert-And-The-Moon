using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraControl : MonoBehaviour
{
    public GameObject albert;
    private Vector3 offset;
    // Start is called before the first frame update
    void Start()
    {
        offset = transform.position - albert.transform.position;
    }

    // Update is called once per frame
    void LateUpdate()
    {
        transform.position = albert.transform.position + offset;
    }
}