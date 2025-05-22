using UnityEngine;

public class CoinReceiver : MonoBehaviour
{
    public GameObject helmet; // drag objek helm dari hierarchy

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Coin"))
        {
            // Hancurkan koin atau sembunyikan
            Destroy(other.gameObject);

            // Munculkan helm
            if (helmet != null)
            {
                helmet.SetActive(true);
            }
        }
    }
}
