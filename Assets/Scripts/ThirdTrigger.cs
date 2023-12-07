using UnityEngine;
using UnityEngine.Playables;

public class ThirdTrigger : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {

        GameObject TeleportTimeline = GameObject.Find("TeleportTimeline");


        if (TeleportTimeline != null)
        {

            PlayableDirector timeline = TeleportTimeline.GetComponent<PlayableDirector>();

            if (timeline != null)
            {

                timeline.Play();
            }
            else
            {
                Debug.LogError("PlayableDirector component not found on TeleportTimeline.");
            }
        }
        else
        {
            Debug.LogError("TeleportTimeline GameObject not found in the scene.");
        }
    }
}
