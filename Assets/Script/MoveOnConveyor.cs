using UnityEngine;

public class MoveOnConveyor : MonoBehaviour
{
    public float moveSpeed = 0.01f;  // Bisa diatur lebih pelan
    private Rigidbody rb;
    private bool onConveyor = false;
    private Vector3 moveDirection;

    private void Start()
    {
        rb = GetComponent<Rigidbody>();

        // Kunci rotasi supaya tidak guling-guling
        rb.constraints = RigidbodyConstraints.FreezeRotation;
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Conveyor"))
        {
            onConveyor = true;
            moveDirection = collision.transform.right;
            Debug.Log("Move Direction: " + moveDirection);
        }
    }

    private void OnCollisionExit(Collision collision)
    {
        if (collision.gameObject.CompareTag("Conveyor"))
        {
            onConveyor = false;
        }
    }

    private void FixedUpdate()
    {
        if (onConveyor)
        {
            Vector3 horizontalVelocity = moveDirection.normalized * moveSpeed;
            Vector3 currentVelocity = rb.velocity;

            // Hanya ubah horizontal, gravity tetap normal
            rb.velocity = new Vector3(horizontalVelocity.x, currentVelocity.y, horizontalVelocity.z);
        }
    }
}
