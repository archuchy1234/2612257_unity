using UnityEngine;

public class DrawerInteraction : MonoBehaviour
{
    public Vector3 openOffset = new Vector3(0, 0, -0.5f); 
    public float openSpeed = 2f;                          
    public KeyCode interactKey = KeyCode.D;               

    private bool isOpen = false;
    private Vector3 closedPosition;
    private Vector3 openPosition;

    void Start()
    {
      
        closedPosition = transform.localPosition;
   
        openPosition = closedPosition + openOffset;
    }

    void Update()
    {
        if (Input.GetKeyDown(interactKey))
        {
            isOpen = !isOpen; 
        }

        if (isOpen)
        {
            transform.localPosition = Vector3.Lerp(transform.localPosition, openPosition, Time.deltaTime * openSpeed);
        }
        else
        {
            transform.localPosition = Vector3.Lerp(transform.localPosition, closedPosition, Time.deltaTime * openSpeed);
        }
    }
}
