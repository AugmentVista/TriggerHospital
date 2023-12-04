using UnityEngine;
using UnityEngine.Playables;

public class CineMachineTrigger : MonoBehaviour
{
    public PlayableDirector timeline;

    // Use this for initialization
    void Start()
    {
        timeline = GetComponent<PlayableDirector>();
    }

    private void OnTriggerEnter(Collider other)
    {
        timeline.Play();  
    }

    private void OnTriggerExit(Collider other)
    { 
    timeline.Stop();
    
    }
}