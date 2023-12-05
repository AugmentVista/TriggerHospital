using UnityEngine;
using UnityEngine.Playables;

public class CineMachineTrigger : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        // Find the Timeline_Manager GameObject in the scene
        GameObject timelineManager = GameObject.Find("Timeline_Manager");

        // Check if the Timeline_Manager GameObject is found
        if (timelineManager != null)
        {
            // Get the PlayableDirector component from the Timeline_Manager
            PlayableDirector timeline = timelineManager.GetComponent<PlayableDirector>();

            // Check if the PlayableDirector component is found
            if (timeline != null)
            {
                // Play the timeline
                timeline.Play();
            }
            else
            {
                Debug.LogError("PlayableDirector component not found on Timeline_Manager.");
            }
        }
        else
        {
            Debug.LogError("Timeline_Manager GameObject not found in the scene.");
        }
    }

    private void OnTriggerExit(Collider other)
    {
        // Find the Timeline_Manager GameObject in the scene
        GameObject timelineManager = GameObject.Find("Timeline_Manager");

        // Check if the Timeline_Manager GameObject is found
        if (timelineManager != null)
        {
            // Get the PlayableDirector component from the Timeline_Manager
            PlayableDirector timeline = timelineManager.GetComponent<PlayableDirector>();

            // Check if the PlayableDirector component is found
            if (timeline != null)
            {
                // Stop the timeline
                timeline.Stop();
                gameObject.SetActive(false);
            }
            else
            {
                Debug.LogError("PlayableDirector component not found on Timeline_Manager.");
            }
        }
        else
        {
            Debug.LogError("Timeline_Manager GameObject not found in the scene.");
        }
    }
}
