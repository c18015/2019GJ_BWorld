using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Scale : MonoBehaviour
{
    bool scale = false;
    void Update()
    {
        if (!scale)
        {
            this.transform.localScale = new Vector2(1.56f, 1.56f);
            scale = true;
        }
    }
}
