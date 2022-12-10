using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TurnMouth : MonoBehaviour
{
    // Start is called before the first frame update
   

    public void MouthMove() {
        gameObject.transform.eulerAngles = new Vector3(
            gameObject.transform.eulerAngles.x - 45,
            gameObject.transform.eulerAngles.y,
            gameObject.transform.eulerAngles.z
            );
    }
}
