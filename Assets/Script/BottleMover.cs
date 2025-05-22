using UnityEngine;

[RequireComponent(typeof(Rigidbody))]
public class BottleMover : MonoBehaviour
{
    public float speed = 2f; // Kecepatan gerak botol

    private Rigidbody rb;

    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    void FixedUpdate()
    {
        // Gerakkan botol ke arah kanan (sumbu X positif)
        rb.velocity = new Vector3(speed, rb.velocity.y, rb.velocity.z);
    }
}
