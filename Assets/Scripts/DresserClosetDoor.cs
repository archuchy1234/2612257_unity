using UnityEngine;

public class DresserClosetDoor : MonoBehaviour
{
    public KeyCode interactKey = KeyCode.J;   
    public float openAngle = 90f;             
    public float openSpeed = 2f;              

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
            isOpen = !isOpen;
        }

        if (isOpen)
            transform.localRotation = Quaternion.Slerp(transform.localRotation, openRotation, Time.deltaTime * openSpeed);
        else
            transform.localRotation = Quaternion.Slerp(transform.localRotation, closedRotation, Time.deltaTime * openSpeed);
    }
}
