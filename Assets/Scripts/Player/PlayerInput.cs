using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerInput : MonoBehaviour
{
    private TopDownMovement motor;

    private void Awake()
    {
        motor = GetComponent<TopDownMovement>();
    }

    private void Update()
    {
        float moveX = Input.GetAxisRaw("Horizontal");
        float moveY = Input.GetAxisRaw("Vertical");
        motor.SetMoveInput(new Vector2(moveX, moveY));
    }
}
