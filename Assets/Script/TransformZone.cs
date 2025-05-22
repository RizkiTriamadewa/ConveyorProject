using UnityEngine;

public class TransformZone : MonoBehaviour
{
    [Tooltip("Prefab pengganti (misalnya: kacamata)")]
    public GameObject replacementPrefab;

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Bottle") || other.GetComponent<BottleMover>())
        {
            Vector3 spawnPos = other.transform.position;
            Quaternion spawnRot = other.transform.rotation;

            Destroy(other.gameObject); // Hancurkan botol
            Instantiate(replacementPrefab, spawnPos, spawnRot); // Ganti jadi kacamata

            Debug.Log("Botol telah diubah menjadi kacamata!");
        }
    }
}
