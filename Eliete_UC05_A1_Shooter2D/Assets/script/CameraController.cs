using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraController : MonoBehaviour
{
    private GameObject player;

  
    void Start()
    {
        player = GameObject.FindWithTag("Player");
    }

    void LateUpdate()
    {
        if (player != null)
        {
            Vector3 newPosition = transform.position;
            newPosition.x = player.transform.position.x;

            transform.position = newPosition;
        }
    }

}

