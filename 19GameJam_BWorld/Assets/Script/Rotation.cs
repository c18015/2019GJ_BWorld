using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rotation : MonoBehaviour
{
    float speed;
    public float rot;

    void Update()
    {
        transform.Rotate(0, 0, rot * 50 * Time.deltaTime);
    }
}
