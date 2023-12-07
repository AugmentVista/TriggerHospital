using UnityEngine;
using UnityEngine.Playables;

public class LastTrigger : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {

        GameObject Trigger = GameObject.Find("LastTimeline");


        if (Trigger != null)
        {

            PlayableDirector timeline = Trigger.GetComponent<PlayableDirector>();


            if (timeline != null)
            {

                timeline.Play();
            }
            else
            {
                Debug.LogError("PlayableDirector component not found on LastTrigger.");
            }
        }
        else
        {
            Debug.LogError("LastTrigger GameObject not found in the scene.");
        }
    }
}
