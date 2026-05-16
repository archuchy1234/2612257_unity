using UnityEngine;

public class DoorInteraction : MonoBehaviour
{
    public float openAngle = 90f;           
    public float openSpeed = 2f;            
    public KeyCode interactKey = KeyCode.H; 

    private bool isOpen = false;
    private Quaternion closedRotation;
    private Quaternion openRotation;

    void Start()
    {
       
        closedRotation = transform.localRotation;
      
        openRotation = Quaternion.Euler(transform.localEulerAngles + new Vector3(0, openAngle, 0));
    }

    void Update()
    {
       
        if (Input.GetKeyDown(interactKey))
        {
            isOpen = !isOpen; // toggle state
        }

        transform.localRotation = Quaternion.Slerp(
            transform.localRotation,
            isOpen ? openRotation : closedRotation,
            Time.deltaTime * openSpeed
        );
    }
}
