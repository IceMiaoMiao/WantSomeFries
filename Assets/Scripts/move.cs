using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class move : MonoBehaviour
{
    void Update()
    {
        this.transform.position += new Vector3(1*Time.deltaTime, 0, 0);
    }
}
