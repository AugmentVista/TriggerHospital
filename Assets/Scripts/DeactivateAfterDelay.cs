using UnityEngine;

public class DeactivateAfterDelay : MonoBehaviour
{

    public GameObject StopBlock;
    public GameObject Self;

    private void OnTriggerEnter(Collider other)
    {
        Invoke("DeactivateObject", 3f);
        Invoke("Oof", 3f);
    }

    private void DeactivateObject()
    {
        StopBlock.SetActive(false);
    }
    private void Oof()
    { 
    Self.SetActive(false);
    
    
    }
}
