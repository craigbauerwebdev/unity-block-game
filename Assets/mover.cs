using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class mover : MonoBehaviour
{
    //int hitPoints = 20;
    //[SerializeField] float xAxis = 0;
    //[SerializeField] float up = 0;
    //[SerializeField] float yAxis = 0;
    //bool isAlive = true;
    //string name = "Leyroy";

    [SerializeField] float moveSpeed = 15f;

    // Start is called before the first frame update
    void Start()
    {
        Debug.Log("Player Spawned");
        transform.Translate(0,0,0);
    }

    // Update is called once per frame
    void Update()
    {
        float xValue = Input.GetAxis("Horizontal") * Time.deltaTime * moveSpeed;
        float zValue = Input.GetAxis("Vertical") * Time.deltaTime * moveSpeed;
        transform.Translate(xValue, 0, zValue);
    }
}
