using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TouchDragObject : MonoBehaviour {
    private bool isDragging = false;
    private Vector3 offset;

    void Update() {
        if (isDragging) {
            if (Input.touchCount > 0) {
                Touch touch = Input.GetTouch(0);
                if (touch.phase == TouchPhase.Moved) {
                   
                    Vector3 newPosition = Camera.main.ScreenToWorldPoint(touch.position) + offset;
                    newPosition.z = 0f;
                    transform.position = newPosition;
                } else if (touch.phase == TouchPhase.Ended) {
                    isDragging = false;
                }
            }
        }
    }

    void OnMouseDown() {
        Debug.Log("ON MOUSE DOWN .....");
        isDragging = true;
        offset = transform.position - Camera.main.ScreenToWorldPoint(Input.mousePosition);
    }

    void OnMouseUp() {
        Debug.Log("ON MOUSE UP......");
        isDragging = false;
    }
}
