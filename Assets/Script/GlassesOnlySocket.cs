using UnityEngine;
using UnityEngine.XR.Interaction.Toolkit;

public class GlassesOnlySocket : XRSocketInteractor
{
    public Transform snapTarget; // Drag objek GlassesShadow ke sini via Inspector

    public override bool CanSelect(IXRSelectInteractable interactable)
    {
        return interactable.transform.CompareTag("Glasess"); // Pastikan tag benar
    }

    protected override void OnSelectEntered(SelectEnterEventArgs args)
    {
        base.OnSelectEntered(args);

        if (snapTarget != null)
        {
            args.interactableObject.transform.SetPositionAndRotation(snapTarget.position, snapTarget.rotation);
            args.interactableObject.transform.SetPositionAndRotation(snapTarget.position, snapTarget.rotation);
        }
    }
}
