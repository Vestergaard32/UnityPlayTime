using System;
using UnityEngine;

public class Movement : MonoBehaviour
{

	private Rigidbody _rigidbody;
	private Collider _collider;
	private float _realMovementSpeed;

	public float MovementSpeed = 500.0f;
	private bool _canJump = true;

	// Use this for initialization
	void Start ()
	{
		_rigidbody = GetComponent<Rigidbody>();
		_collider = GetComponent<Collider>();
	}
	
	// Update is called once per frame
	void Update ()
	{
		_realMovementSpeed = MovementSpeed * Time.deltaTime;
		if(Input.GetKey(KeyCode.W))
			_rigidbody.AddForce(Vector3.forward * _realMovementSpeed);
		else if(Input.GetKey(KeyCode.S))
		{
			_rigidbody.AddForce(-Vector3.forward * _realMovementSpeed);
		}
		else if (Input.GetKey(KeyCode.A))
		{
			_rigidbody.AddForce(Vector3.left * _realMovementSpeed);
		}
		else if (Input.GetKey(KeyCode.D))
		{
			_rigidbody.AddForce(-Vector3.left * _realMovementSpeed);
		}
		
		if (Input.GetKey(KeyCode.Space) && _canJump)
		{
			_rigidbody.AddForce(Vector3.up * _realMovementSpeed * 100);
			_canJump = false;
			Debug.Log("Jumping");
		}
	}

	private void OnCollisionEnter(Collision other)
	{
		
		if (other.collider.name == "Floor")
		{
			Debug.Log("Hitting floor");
			_canJump = true;
		}
	}
}
