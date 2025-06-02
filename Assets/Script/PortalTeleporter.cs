using Unity.XR.CoreUtils;
using UnityEngine;

public class PortalTeleporter : MonoBehaviour
{
    [Tooltip("Portal tujuan teleportasi")]
    public Transform targetPortal;

    [Tooltip("Offset vertikal untuk menyesuaikan tinggi XR Origin saat teleportasi")]
    public float verticalOffset = 1.5f;

    private void OnTriggerEnter(Collider other)
    {
        // Cek apakah collider yang masuk adalah XR Origin (XR Rig)
        XROrigin xrOrigin = other.GetComponentInParent<XROrigin>();
        if (xrOrigin == null || targetPortal == null)
            return;

        // Ambil posisi target portal dan tambahkan offset ke atas
        Vector3 destination = targetPortal.position + Vector3.up * verticalOffset;

        // Teleportasi XR Origin ke posisi tersebut
        xrOrigin.transform.position = destination;
    }

    // Opsional: Visualisasi posisi target portal di Scene view
    private void OnDrawGizmos()
    {
        if (targetPortal != null)
        {
            Gizmos.color = Color.green;
            Gizmos.DrawWireSphere(targetPortal.position + Vector3.up * 2f, 0.2f);
        }
    }
}
