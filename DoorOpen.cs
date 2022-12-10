using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class DoorOpen : MonoBehaviour
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
                    if (hit.collider.gameObject.tag == "door") {
                        if (hit.collider.gameObject.GetComponent<Door>().state == "closed") {
                            hit.collider.gameObject.transform.eulerAngles = new Vector3(
                                hit.collider.gameObject.transform.eulerAngles.x,
                                hit.collider.gameObject.GetComponent<Door>().openAngle,
                                hit.collider.gameObject.transform.eulerAngles.z
                                );
                            hit.collider.gameObject.GetComponent<Door>().state = "open";
                        }

                        else if (hit.collider.gameObject.GetComponent<Door>().state == "open") {
                            hit.collider.gameObject.transform.eulerAngles = new Vector3(
                                hit.collider.gameObject.transform.eulerAngles.x,
                                hit.collider.gameObject.GetComponent<Door>().closedAngle,
                                hit.collider.gameObject.transform.eulerAngles.z
                                );
                            hit.collider.gameObject.GetComponent<Door>().state = "closed";
                        }
                    }
                }
            }
        }
    }
}