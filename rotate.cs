using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class rotate : MonoBehaviour
{
    // Start is called before the first frame update
    public bool rotate_model = false;
    public Vector3[] positions;
    public int state = 0;
    public int total_states = 2;
    public int rotates = 0;
    public TurnMouth mouth;
    void Start()
    {
        positions = new Vector3[total_states];
        positions[0] = new Vector3(0, -90, 0);
        mouth = (TurnMouth) GameObject.Find("mouth").GetComponent("TurnMouth");
        
    }

    // Update is called once per frame
    void Update()
    {
        if (rotate_model && rotates < 2) {
            gameObject.transform.eulerAngles = new Vector3(
            gameObject.transform.eulerAngles.x - 90,
            gameObject.transform.eulerAngles.y,
            gameObject.transform.eulerAngles.z
            );

            rotate_model = false;
            rotates += 1;
            if (rotates >= 2) {
                mouth.MouthMove();
            }
        }
    }
}
