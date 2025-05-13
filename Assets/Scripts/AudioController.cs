using UnityEngine;
using System.Collections;
using UnityEngine.Events;
using System.Collections.Generic;


public class AudioController : MonoBehaviour
{

    AudioSource audioSource;

    [SerializeField]
    private List<VoiceLineAction> voiceLineActions;

    private int currentIndex;

    private void Awake()
    {
       
        if (audioSource == null)
        {
            audioSource = gameObject.AddComponent<AudioSource>();
            audioSource.playOnAwake = false;
        }
        currentIndex = 0;
        PlayClip(currentIndex);
    }

    public void PlayClip(int index)
    {
        currentIndex = index;
        VoiceLineAction clipData = voiceLineActions[currentIndex];
        if (clipData.audioClip == null) return;

        StartCoroutine(PlayAndTrigger(clipData));
    }
    
    private IEnumerator PlayAndTrigger(VoiceLineAction clipData)
    {
        yield return new WaitForSeconds(0.5f);
        audioSource.clip = clipData.audioClip;
        audioSource.Play();

        yield return new WaitForSeconds(clipData.audioClip.length);

        clipData.onClipFinished?.Invoke();
    }
}
[System.Serializable]
public class VoiceLineAction
{
    public AudioClip audioClip;
    public UnityEvent onClipFinished;
}
