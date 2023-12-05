using UnityEngine;

public class DeactivateAfterDelay : MonoBehaviour
{

    public GameObject StopBlock;

    private void OnTriggerEnter(Collider other)
    {
        // Invoke the DeactivateObject method after 3 seconds
        
        Invoke("DeactivateObject", 3f);
    }

    private void DeactivateObject()
    {
        // Set the GameObject to inactive after the delay
        StopBlock.SetActive(false);
    }
}
