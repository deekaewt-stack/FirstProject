using UnityEngine;
using UnityEngine.InputSystem; // This was missing!

public class PlayerMovement : MonoBehaviour
{
    [SerializeField] private float moveSpeed = 5f;
    private Rigidbody2D rb;
    private Vector2 moveInput;

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    void Update()
    {
        // This moves your player using the physics system
        rb.linearVelocity = moveInput * moveSpeed;
    }

    // This connects to your Player Input component in Unity
    public void Move(InputAction.CallbackContext context)
    {
        moveInput = context.ReadValue<Vector2>();
    }
}