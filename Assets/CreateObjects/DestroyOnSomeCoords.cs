using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyOnSomeCoords : MonoBehaviour
{
    void Update()
    {
        if(gameObject.transform.position.y <= -1000f)
        {
            Destroy(gameObject);
        }
    }
}
