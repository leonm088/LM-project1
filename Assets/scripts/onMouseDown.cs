using UnityEngine;

public class onMouseDown : MonoBehaviour
{
      void OnMouseDown() //this is a method that is part of Unity's Libraries/Monobehaviour
    {
        Destroy(gameObject); //this destroys the object that this script is attached to
        Debug.Log("LeftMouse Button Clicked");

    }
}
