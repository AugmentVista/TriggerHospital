using UnityEngine;
using UnityEngine.Playables;

public class LightTimelineManager : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {

        GameObject lightTimelineManager = GameObject.Find("LightTimelineManager");


        if (lightTimelineManager != null)
        {

            PlayableDirector timeline = lightTimelineManager.GetComponent<PlayableDirector>();


            if (timeline != null)
            {

                timeline.Play();
            }
            else
            {
                Debug.LogError("PlayableDirector component not found on LightTimelineManager.");
            }
        }
        else
        {
            Debug.LogError("LightTimelineManager GameObject not found in the scene.");
        }
    }
}
