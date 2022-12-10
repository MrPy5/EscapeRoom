using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class TurnHorn : MonoBehaviour
{
    public Transform crosshair;
  

    public GameObject player;
   
 
    void Update ()
    {
        if (Input.GetMouseButtonDown(0)) {
            RaycastHit hit;
            if (Physics.Raycast(crosshair.transform.position, crosshair.transform.TransformDirection(Vector3.forward), out hit))
            {
                if (hit.collider && Vector3.Distance(hit.collider.gameObject.transform.position, player.transform.position) < 4)
                {
                    if (hit.collider.gameObject.tag == "horn") {
                        hit.collider.gameObject.GetComponent<rotate>().rotate_model = true;
                    }
                }
            }
        }
    }
}