using UnityEngine;

public class TransformZones : MonoBehaviour
{
    [Tooltip("Packing)")]
    public GameObject replacementPrefab;

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Glasess") || other.GetComponent<BottleMover>())
        {
            // Tambahkan offset ke arah Z depan botol (1 unit)
            Vector3 spawnPos = other.transform.position + other.transform.forward * 1.0f;
            Quaternion spawnRot = other.transform.rotation;

            // Hancurkan botol
            Destroy(other.gameObject);

            // Spawn prefab di posisi yang telah disesuaikan
            Instantiate(replacementPrefab, spawnPos, spawnRot);

            Debug.Log("Kacamata telah dipacking");
        }
    }
}
