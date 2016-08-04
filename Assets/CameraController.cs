using UnityEngine;
using System.Collections;

public class CameraController : MonoBehaviour {
    public float scrollSpeed;
    public float boundsWidth;
    public float cameraSpeed;

	void FixedUpdate () {
        scrollSpeed = Mathf.Max(scrollSpeed, 0.5f);
        float z = Camera.main.transform.position.z;
        if (Input.GetAxis("Mouse ScrollWheel") < 0 || Camera.main.transform.position.z > 2f){
            Camera.main.transform.position -= Vector3.forward * scrollSpeed * z * Time.fixedDeltaTime * (Input.GetAxis("Mouse ScrollWheel"));
        }
        if(Input.mousePosition.x < boundsWidth || Input.GetKey(KeyCode.A))
        {
            Camera.main.transform.position += Vector3.right * cameraSpeed * z * Time.fixedDeltaTime;
        }
        if (Input.mousePosition.x > Screen.width - boundsWidth || Input.GetKey(KeyCode.D))
        {
            Camera.main.transform.position -= Vector3.right * cameraSpeed * z * Time.fixedDeltaTime;
        }
        if (Input.mousePosition.y < boundsWidth || Input.GetKey(KeyCode.S))
        {
            Camera.main.transform.position -= Vector3.up * cameraSpeed * z * Time.fixedDeltaTime;
        }
        if (Input.mousePosition.y > Screen.height - boundsWidth || Input.GetKey(KeyCode.W))
        {
            Camera.main.transform.position += Vector3.up * cameraSpeed * z * Time.fixedDeltaTime;
        }
    }
}
