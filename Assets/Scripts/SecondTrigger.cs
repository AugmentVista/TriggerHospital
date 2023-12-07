using UnityEngine;
using UnityEngine.Playables;

public class SecondTrigger : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {

        GameObject timelineManager = GameObject.Find("Timeline_Manager");


        if (timelineManager != null)
        {

            PlayableDirector timeline = timelineManager.GetComponent<PlayableDirector>();


            if (timeline != null)
            {

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
}
