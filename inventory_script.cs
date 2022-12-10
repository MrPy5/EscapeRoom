using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

using UnityEngine.UI;
public class inventory_script : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject[] inventory;
    public int empty = 0;
    public int selected = 0;
    public Sprite inventory_pic;
    public TextMeshProUGUI selectedText;

    void Start()
    {
        inventory = new GameObject[5];
    }

    // Update is called once per frame
    void Update()
    {
        
        if (Input.GetKeyDown("left")) {
            GameObject.Find((gameObject.GetComponent<inventory_script>().selected + 1).ToString()).GetComponent<Image>().sprite = inventory_pic;
            if (selected <= 0) {
                selected = 4;
            }
            else {
                selected -= 1;
            }

            
            
            
        }
        if (Input.GetKeyDown("right")) {
            GameObject.Find((gameObject.GetComponent<inventory_script>().selected + 1).ToString()).GetComponent<Image>().sprite = inventory_pic;
            if (selected >= 4) {
                selected = 0;
            }
            else {
                selected += 1;
            }
            
            
        }
        if (inventory[selected] != null) {
            selectedText.text = inventory[selected].name;
        }
        else {
            selectedText.text = "";
        }
    }
}
