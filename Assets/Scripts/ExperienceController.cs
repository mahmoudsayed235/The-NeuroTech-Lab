using UnityEngine;
using UnityEngine.Events;

public class ExperienceController : MonoBehaviour
{
   
    public int totalSteps = 5;

    private int correctSteps = 0;

    public UnityEvent onStepRight;
    public UnityEvent onStepWrong;
    public UnityEvent onExperienceComplete;

    public void StepRight()
    {
        correctSteps++;
        onStepRight?.Invoke();
        CheckIfDone();
    }

    public void StepWrong()
    {
        onStepWrong?.Invoke();
        CheckIfDone();
    }

    private void CheckIfDone()
    {
        if (correctSteps == totalSteps)
        {
            onExperienceComplete?.Invoke();
        }
    }

    public void ResetExperience()
    {
        correctSteps = 0;
    }
}
