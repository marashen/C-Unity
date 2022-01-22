using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WinTrigger : MonoBehaviour
{
    void Update()
    {
        if (transform.position.y > 10f)
        {
            Debug.Log("You Win");
        }
    }
}
