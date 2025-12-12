using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraFollow : MonoBehaviour
{
    //Player da seguire. Nota: assegnare il player nell'inspector
    [SerializeField] private Transform target;

    //Questa parte non è necessaria
    //  Distanza Camera-Target. 
    //  public Vector3 offset;
    //  velocita` del movimento
    //  [Range(0, 10)]
    //  public float smoothness;


    //Come concordato ieri non sono più usabili, quindi le commento
    //  attivare i limiti della mappa e settarli
    //  checkbox nell inspector
    //  public bool enableBoundaries = true;
    //  public float minX = 0f;
    //  public float maxX = 0f;
    //  public float minY = 0f;
    //  public float maxY = 0f;
    //  chiedere a Paolo i limiti della mappa per settarli.

    void LateUpdate()
    {
        //Se la funzione non deve essere richiamata in più punti del codice, non ha senso creare una funzione a parte.
        // Follow();


        //Script che fa seguire la camera al player con offset su z
        //Check if player exists
        if (target == null)
            return;

        //Take 2D player position
        Vector2 targetPos2D = target.position;

        //Keep camera at a offset on the z axis
        transform.position = new Vector3(targetPos2D.x, targetPos2D.y, transform.position.z);
    }

    //Commentato perchè non più usato
    //void Follow()
    //{
    //    //posizione desiderata+smooth
    //    Vector3 targetPosition = target.position + offset;
    //    Vector3 smoothedPosition = Vector3.Lerp(transform.position, targetPosition, smoothness * Time.deltaTime);
    //    //applica i limiti della mappa 
    //    if (enableBoundaries)
    //    {
    //        smoothedPosition.x = Mathf.Clamp(smoothedPosition.x, minX, maxX);
    //        smoothedPosition.y = Mathf.Clamp(smoothedPosition.y, minY, maxY);
    //    }
    //    transform.position = smoothedPosition;

    //}

}
