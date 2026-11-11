
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    private float movementSpeed = 5f;
    private float minY = -4f;
    private float maxY = 4f;

    private Rigidbody2D rb;
    private float movementInput;

    private void Awake()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    public void SetMovementInput(float input)
    {
        movementInput = Mathf.Clamp(input, -1f, 1f);
    }

    private void FixedUpdate()
    {
        float newY = rb.position.y
            + movementInput * movementSpeed * Time.fixedDeltaTime;

        newY = Mathf.Clamp(newY, minY, maxY);

        rb.MovePosition(new Vector2(rb.position.x, newY));
    }
}
