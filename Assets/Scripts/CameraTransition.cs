using UnityEngine;
using Cinemachine;

public class CameraTransition : MonoBehaviour
{
    public CinemachineVirtualCameraBase cameraToActivate;
    public CinemachineVirtualCameraBase cameraToDeactivate;

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {

            cameraToDeactivate.Priority = 0;

            cameraToActivate.Priority = 10; 
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.CompareTag("Player"))
        {

            cameraToActivate.Priority = 0;

            cameraToDeactivate.Priority = 10; 
        }
    }
}

