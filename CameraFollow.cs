﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraFollow : MonoBehaviour
{

    public GameObject player;
    public int cameraBackPosition = 10;

    void LateUpdate()
    {
        transform.position = new Vector3(0, gameObject.transform.position.y, player.gameObject.transform.position.z - cameraBackPosition);
    }

    //void LateUpdate()
    //{
    //    gameObject.transform.position = Vector3.Lerp(gameObject.transform.position, new Vector3(0, gameObject.transform.position.y, player.transform.position.z - cameraBackPosition), Time.deltaTime * 100);
    //}
}
