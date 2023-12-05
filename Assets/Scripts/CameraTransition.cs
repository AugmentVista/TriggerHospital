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
            // Deactivate the current camera
            cameraToDeactivate.Priority = 0;

            // Activate the new camera
            cameraToActivate.Priority = 10; // Set the priority based on your scene requirements
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            // Deactivate the new camera
            cameraToActivate.Priority = 0;

            // Activate the previous camera
            cameraToDeactivate.Priority = 10; // Set the priority based on your scene requirements
        }
    }
}

