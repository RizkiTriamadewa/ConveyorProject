using UnityEngine;

public class ButtonSpawner : MonoBehaviour
{
    [Tooltip("Prefab Coin yang akan di-spawn")]
    public GameObject coinPrefab;

    [Tooltip("Transform tempat coin muncul")]
    public Transform spawnPoint;

    [Tooltip("Tag objek pemicu (misal: Cylinder)")]
    public string triggerTag = "Cylinder";  // pastikan tag diatur di Unity

    [Tooltip("Apakah hanya bisa ditekan sekali?")]
    public bool oneTimeUse = false;

    private bool hasSpawned = false;

    private AudioSource audioSource;

    private void Start()
    {
        audioSource = GetComponent<AudioSource>();
    }

    private void OnTriggerEnter(Collider other)
    {
        if (!hasSpawned && other.CompareTag(triggerTag))
        {
            SpawnCoin();

            if (oneTimeUse)
                hasSpawned = true;
        }
    }

    private void SpawnCoin()
    {
        Instantiate(coinPrefab, spawnPoint.position, Quaternion.identity);

        if (audioSource != null)
            audioSource.Play();

        Debug.Log("Koin telah muncul karena silinder menekan tombol.");
    }
}
