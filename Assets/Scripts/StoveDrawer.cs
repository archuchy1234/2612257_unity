using UnityEngine;

public class StoveDrawer : MonoBehaviour
{
    public float openDistance = 0.5f;   
    public float openSpeed = 2f;        
    private bool isOpen = false;
    private Vector3 closedPosition;
    private Vector3 openPosition;

    void Start()
    {
      
        closedPosition = transform.localPosition;
        
        openPosition = closedPosition + new Vector3(0, -openDistance, 0);
    }

    void Update()
    {
    
        if (Input.GetKeyDown(KeyCode.O))
        {
            isOpen = !isOpen;
        }

        transform.localPosition = Vector3.Lerp(
            transform.localPosition,
            isOpen ? openPosition : closedPosition,
            Time.deltaTime * openSpeed
        );
    }
}
