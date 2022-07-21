using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RecticleRotation : MonoBehaviour
{


    // Start is called before the first frame update
    
    // Update is called once per frame
    void Update()
    {
        transform.Rotate(0, 3, 0, Space.World);
    }
}
