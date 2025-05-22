using UnityEngine;
using UnityEngine.XR.Interaction.Toolkit;

public class SnapZoneTrigger : MonoBehaviour
{
    public GameObject helmet;

    private XRSocketInteractor socket;

    void Start()
    {
        socket = GetComponent<XRSocketInteractor>();
    }

    void Update()
    {
        if (socket.hasSelection && !helmet.activeSelf)
        {
            helmet.SetActive(true);
        }
    }
}
