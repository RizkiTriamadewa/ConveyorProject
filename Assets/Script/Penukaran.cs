using UnityEngine;

public class Penukaran : MonoBehaviour
{
    [Tooltip("Panukaran)")]
    public GameObject replacementPrefab;

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Coin") || other.GetComponent<BottleMover>())
        {
            Vector3 spawnPos = other.transform.position + other.transform.forward * 1.0f;

            // Tetap pakai Quaternion.identity atau rotasi awal (jika perlu)
            GameObject newObj = Instantiate(replacementPrefab, spawnPos, Quaternion.identity);

            // Ubah rotasi X menjadi -90 derajat (dan biarkan Y & Z tetap atau sesuaikan)
            newObj.transform.eulerAngles = new Vector3(-90f, newObj.transform.eulerAngles.y, newObj.transform.eulerAngles.z);

            // Hancurkan objek asal
            Destroy(other.gameObject);

            Debug.Log("Coin telah diterima, dan silahkan ambil Helm!");
        }
    }
}
