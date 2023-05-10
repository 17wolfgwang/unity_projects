using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spinner : MonoBehaviour
{
    [SerializeField] float xValue = 0;
    [SerializeField] float yValue = 1f;
    [SerializeField] float zValue = 0;

    // Update is called once per frame
    void Update()
    {
        transform.Rotate(xValue,yValue,zValue);
    }
}
