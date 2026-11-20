using UnityEngine;

public class FirstPersonCamera : MonoBehaviour
{
//variables
public Transform player;
public float mousesensitivity = 2f;
float cameraVerticalRotation = 0f;


void Start()
    {
        // Lock and Hide the Cursor
        Cursor.lockState = CursorLockMode.Locked;
    }
void Update()
{
    // Collect mouse input

    float inputX=Input.GetAxis("Mouse X")*mousesensitivity;
    float inputY=Input.GetAxis("Mouse Y")*mousesensitivity;

    // Rotate the Player Object and the Camera around its Y axis

    cameraVerticalRotation -= inputY;
    cameraVerticalRotation = Mathf.Clamp(cameraVerticalRotation, -90f, 90f);
    transform.localEulerAngles = Vector3.right * cameraVerticalRotation;
    
    // Rotate the player object and the Camera around its Y axis

    player.Rotate(Vector3.up * inputX);

}

}



