using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraFollow : MonoBehaviour
{      
    //player da seguire
    public Transform player;

    //distanza tra camera e player
    public Vector3 offset = new(0f, 0f, -10f);

    //velocita` movimento camera
    public float smoothSpeed = 0.5f;

    //attivare i limiti della mappa e settarli
    public bool enableBoundaries = true;
    public float minX = 0f;
    public float maxX = 0f;
    public float minY = 0f;
    public float maxY = 0f;
    //chiedere a Paolo i limiti della mappa per settarli.
   
    // Start is called before the first frame update
    void Start()
    {
        if (player == null)
        {
         GameObject playerObject = GameObject.FindGameObjectWithTag("Player");
            if (playerObject != null)
            {
                player = playerObject.transform;
            }
        }
    }

    void LateUpdate()
    {
        Vector3 desiredPosition = player.position + offset;

        Vector3 smoothedPosition = Vector3.Lerp(transform.position, desiredPosition, smoothSpeed);
        
        if (enableBoundaries) 
        {
            smoothedPosition.x = Mathf.Clamp(smoothedPosition.x, minX, maxX);

            smoothedPosition.y = Mathf.Clamp(smoothedPosition.y, minY, maxY);
        }
           transform.position = smoothedPosition;
    }
}
