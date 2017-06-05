using UnityEngine;
using System.Collections;
using UnityEngine.Audio;

public class MusicController : MonoBehaviour {

    [SerializeField] private AudioMixer audioMixer;
    [SerializeField] private AudioMixerSnapshot quiet;
    [SerializeField] private AudioMixerSnapshot cave;
    [SerializeField] private AudioMixerSnapshot action;

    // Use this for initialization
    void Start () {
	
	}

    void OnTriggerEnter(Collider hit) {
        if (hit.gameObject.tag.Contains("Action")) {
            action.TransitionTo(1);
        }
        if (hit.gameObject.tag.Contains("Cave")) {
            cave.TransitionTo(1);
        }
    }

    void OnTriggerExit(Collider hit) {
        quiet.TransitionTo(1);
    }

	// Update is called once per frame
	void Update () {
	
	}
}
