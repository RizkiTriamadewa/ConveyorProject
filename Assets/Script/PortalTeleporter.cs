using Unity.XR.CoreUtils;
using UnityEngine;

public class PortalTeleporter : MonoBehaviour
{
    [Tooltip("Portal tujuan teleportasi")]
    public Transform targetPortal;

    private void OnTriggerEnter(Collider other)
    {
        // Cek apakah ada XR Origin (XR Rig) di parent collider yang menyentuh trigger
        XROrigin xrOrigin = other.GetComponentInParent<XROrigin>();
        if (xrOrigin == null || targetPortal == null)
            return;

        // Teleport langsung ke posisi portal
        xrOrigin.transform.position = targetPortal.position;
    }

    // Opsional: Visualisasi target portal
    private void OnDrawGizmos()
    {
        if (targetPortal != null)
        {
            Gizmos.color = Color.green;
            Gizmos.DrawWireSphere(targetPortal.position + Vector3.up * 2f, 0.2f);
        }
    }
}
