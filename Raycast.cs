using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Raycast : MonoBehaviour
{
    public Transform crosshair;
  
    public GameObject pick_up;
    public GameObject player;
   
 
    void Update ()
    {
        if (Input.GetMouseButtonDown(0)) {
            RaycastHit hit;
            if (Physics.Raycast(crosshair.transform.position, crosshair.transform.TransformDirection(Vector3.forward), out hit))
            {
                if (hit.collider)
                {
            
                    if (hit.collider.gameObject.GetComponent<Holdable>() && Vector3.Distance(hit.collider.gameObject.transform.position, player.transform.position) < 4) {
                        pick_up = hit.collider.gameObject;
                        pick_up.GetComponent<Holdable>().player = player;
                        pick_up.GetComponent<Holdable>().seton = null;
                        
                    }
                    else {
                        pick_up = null;
                        
                    }

                    if (hit.collider.gameObject.GetComponent<SetDownPlace>() && Vector3.Distance(hit.collider.gameObject.transform.position, player.transform.position) < 4) {
                        player.GetComponent<inventory_script>().inventory[player.GetComponent<inventory_script>().selected].SetActive(true);
                        player.GetComponent<inventory_script>().inventory[player.GetComponent<inventory_script>().selected].GetComponent<Holdable>().seton = hit.collider.gameObject;
                        player.GetComponent<inventory_script>().inventory[player.GetComponent<inventory_script>().selected].transform.parent = null;
                        player.GetComponent<inventory_script>().inventory[player.GetComponent<inventory_script>().selected].transform.localPosition = new Vector3(0,0,0);
                        player.GetComponent<inventory_script>().inventory[player.GetComponent<inventory_script>().selected].transform.localRotation = Quaternion.identity;
                        player.GetComponent<inventory_script>().inventory[player.GetComponent<inventory_script>().selected] = null;
                    }
                }
            
            }
        }

        
    }  
}

