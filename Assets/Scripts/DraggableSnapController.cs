using UnityEngine;
using UnityEngine.Events;

public class DraggableSnapController : MonoBehaviour
{
    private Vector3 initialPosition;
    private Quaternion initialRotation;

    private Transform validSnapTarget = null;

    [SerializeField]
    private string goalObjectName;
    private string triggeredObjectName;


    public UnityEvent onTriggerEntered;
    public UnityEvent onTriggerEnteredWrong;

    private void Awake()
    {
        initialPosition = transform.position;
        initialRotation = transform.rotation;
    }

    private void OnTriggerEnter(Collider other)
    {
        // You can tag valid targets with "SnapTarget"
        if (other.name.Equals(goalObjectName))
        {
            validSnapTarget = other.transform;
        }
        else
        {
            triggeredObjectName = other.name;
        }
    }

    
    private void OnTriggerExit(Collider other)
    {
        validSnapTarget = null;
        triggeredObjectName = "";
    }
    [ContextMenu("Test OnReleased")]
    
    public void OnReleased()
    {
        if (validSnapTarget != null)
        {
            transform.SetParent(validSnapTarget);
            transform.localPosition = Vector3.zero;
            transform.localRotation = Quaternion.identity;
            onTriggerEntered?.Invoke();
        }
        else
        {
            transform.position = initialPosition;
            transform.rotation = initialRotation;
            if (!string.IsNullOrEmpty(triggeredObjectName)) {
                onTriggerEnteredWrong?.Invoke();
            }
        }
    }
}
