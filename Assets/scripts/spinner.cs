using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class spinner : MonoBehaviour
{
    [SerializeField] float xAngle;
    [SerializeField] float yAngle;
    [SerializeField] float zAngle;
    // Start is called before the first frame update
    

    // Update is called once per frame
    void Update()
    {
        transform.Rotate(xAngle, yAngle, zAngle);
    }
}
