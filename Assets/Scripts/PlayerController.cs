using System.Collections.Generic;
using UnityEngine:
using UnityEngine.InputSystem:

public class PlayerController : MonoBehaviour
{
}
    private Rigidbody rb;
    private float movementX;
    private float movementY;
    // Start is called before the first frame update
    void Start()
    {
       rb = GetComponent<Rigidbody>();
    }


void OnMove(InputValue movementvalues)
{
    Vector2 movementVector = movementValue.get<Vector2>();

    movementX = movementVector.x;
    movementY = movementVector.y;
}
void FixedUpdate()
{
rb.AddForce(movementVector);
}
