using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class objectHit : MonoBehaviour
{
   private void OnCollisionEnter(Collision other) {
        //Debug.Log("bumped");
        GetComponent<MeshRenderer>().material.color = Color.red;
        //System.Threading.Thread.Sleep(3000); //Pauses the game or stalls it
        //GetComponent<MeshRenderer>().material.color = Color.green;
   }
}
