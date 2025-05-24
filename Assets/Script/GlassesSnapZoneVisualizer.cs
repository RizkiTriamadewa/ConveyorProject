using UnityEngine;

public class GlassesSnapZoneVisualizer : MonoBehaviour
{
    public GameObject shadowVisual;

    void Start()
    {
        if (shadowVisual != null)
        {
            shadowVisual.SetActive(false); // Sembunyikan saat start
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Glasess") && shadowVisual != null)
        {
            shadowVisual.SetActive(true); // Tampilkan saat kacamata masuk zona
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.CompareTag("Glasess") && shadowVisual != null)
        {
            shadowVisual.SetActive(false); // Sembunyikan saat keluar zona
        }
    }
}
