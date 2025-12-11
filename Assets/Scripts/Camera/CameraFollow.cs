using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraFollow : MonoBehaviour
{
    //Player da seguire
    public Transform target;
    //Distanza Camera-Target
    public Vector3 offset;
    //velocita` del movimento
    [Range(0, 10)]
    public float smoothness;



    //attivare i limiti della mappa e settarli
    //checkbox nell inspector

    public bool enableBoundaries = true;
    public float minX = 0f;
    public float maxX = 0f;
    public float minY = 0f;
    public float maxY = 0f;
    //chiedere a Paolo i limiti della mappa per settarli.

    void LateUpdate()
    {
        Follow();
    }

    void Follow()
    {
        //posizione desiderata+smooth
        Vector3 targetPosition = target.position + offset;
        Vector3 smoothedPosition = Vector3.Lerp(transform.position, targetPosition, smoothness * Time.deltaTime);
        //applica i limiti della mappa 
        if (enableBoundaries)
        {
            smoothedPosition.x = Mathf.Clamp(smoothedPosition.x, minX, maxX);
            smoothedPosition.y = Mathf.Clamp(smoothedPosition.y, minY, maxY);
        }
        transform.position = smoothedPosition;

    }

}
