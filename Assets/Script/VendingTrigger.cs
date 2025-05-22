using UnityEngine;
using Unity.XR.CoreUtils;
using UnityEngine.XR.Management;
using UnityEngine.XR.Interaction.Toolkit;

public class VendingTrigger : MonoBehaviour
{
    public CanvasGroup popupUI;

    private void OnTriggerEnter(Collider other)
    {
        if (other.GetComponent<XROrigin>() != null)
        {
            popupUI.alpha = 1;
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.GetComponent<XROrigin>() != null)
        {
            popupUI.alpha = 0;
        }
    }
}
