using UnityEngine;

public class CameraFollow : MonoBehaviour
{
	public Camera _mainCamera;
	
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		_mainCamera.transform.position = new Vector3(transform.position.x, transform.position.y+5, transform.position.z);
//		_mainCamera.transform.LookAt(transform);
	}
}
