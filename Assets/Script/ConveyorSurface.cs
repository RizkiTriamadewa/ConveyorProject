using UnityEngine;

public class ConveyorSurface : MonoBehaviour
{
    public float conveyorSpeed = 2f;

    void OnCollisionStay(Collision collision)
    {
        Rigidbody rb = collision.rigidbody;
        if (rb != null)
        {
            rb.velocity = new Vector3(conveyorSpeed, rb.velocity.y, rb.velocity.z);
        }
    }
}
