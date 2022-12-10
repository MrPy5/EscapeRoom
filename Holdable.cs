using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Holdable : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject player;
    public GameObject seton;
    public float OffsetY = 0;
    public bool held;


    public Sprite inventory_pic;

    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (player != null) {
            transform.position = Vector3.MoveTowards(transform.position, player.transform.position, 10f * Time.deltaTime);
            if (transform.position == player.transform.position) {
                held = true;
                int openSpot = 0;

                for(int i = 0; i < player.GetComponent<inventory_script>().inventory.Length; i++) {
                    if(player.GetComponent<inventory_script>().inventory[i] == null)
                    {
                        openSpot = i;
                        break;
                    }
                }
                player.GetComponent<inventory_script>().inventory[openSpot] = gameObject;
       
                gameObject.transform.parent = player.transform;
                
                gameObject.SetActive(false);
                held = true;
                player = null;
            }
        }

        if (seton != null) {
            transform.position = new Vector3(seton.transform.position.x, seton.transform.position.y + OffsetY, seton.transform.position.z);
            
            //transform.rotation = seton.transform.rotation;
        }
        
       

        
    }
}
