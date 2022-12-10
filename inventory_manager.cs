using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class inventory_manager : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject one_inventory;
    public GameObject two_inventory;
    public GameObject three_inventory;
    public GameObject four_inventory;
    public GameObject five_inventory;

    public Sprite selected_pic;
    public Sprite inner_pic;

    public GameObject player;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Update_Inventory();
    }

    void Update_Inventory() {
        if  (player.GetComponent<inventory_script>().inventory[0] != null) {
        one_inventory.GetComponent<Image>().sprite = player.GetComponent<inventory_script>().inventory[0].GetComponent<Holdable>().inventory_pic;
        }
        if  (player.GetComponent<inventory_script>().inventory[1] != null) {
        two_inventory.GetComponent<Image>().sprite = player.GetComponent<inventory_script>().inventory[1].GetComponent<Holdable>().inventory_pic;
        }
        if  (player.GetComponent<inventory_script>().inventory[2] != null) {
        three_inventory.GetComponent<Image>().sprite = player.GetComponent<inventory_script>().inventory[2].GetComponent<Holdable>().inventory_pic;
        }
        if  (player.GetComponent<inventory_script>().inventory[3] != null) {
        four_inventory.GetComponent<Image>().sprite = player.GetComponent<inventory_script>().inventory[3].GetComponent<Holdable>().inventory_pic;
        }
        if  (player.GetComponent<inventory_script>().inventory[4] != null) {
        five_inventory.GetComponent<Image>().sprite = player.GetComponent<inventory_script>().inventory[4].GetComponent<Holdable>().inventory_pic;
        }

        if  (player.GetComponent<inventory_script>().inventory[0] == null) {
        one_inventory.GetComponent<Image>().sprite = inner_pic;
        }
        if  (player.GetComponent<inventory_script>().inventory[1] == null) {
        two_inventory.GetComponent<Image>().sprite = inner_pic;
        }
        if  (player.GetComponent<inventory_script>().inventory[2] == null) {
        three_inventory.GetComponent<Image>().sprite = inner_pic;
        }
        if  (player.GetComponent<inventory_script>().inventory[3] == null) {
        four_inventory.GetComponent<Image>().sprite = inner_pic;
        }
        if  (player.GetComponent<inventory_script>().inventory[4] == null) {
        five_inventory.GetComponent<Image>().sprite = inner_pic;
        }
        
        GameObject.Find((player.GetComponent<inventory_script>().selected + 1).ToString()).GetComponent<Image>().sprite = selected_pic;
    }
}
