using UnityEngine;
using System.Collections;

public class Player : MonoBehaviour 
{
	public float speed = 10;
	public float runSpeed = 15;
	public float enegry;

	public GameObject camera;
	// Use this for initialization
	void Start () 
    {
		enegry = 100;
	}
	
	// Update is called once per frame
	void Update () 
    {
		float zTrans = 0;
		float xTrans = 0;
		
		zTrans = Input.GetAxis("Vertical") * speed * Time.deltaTime;
		xTrans = Input.GetAxis("Horizontal") * speed * Time.deltaTime;
		
		Vector3 move = new Vector3(xTrans,0, zTrans);

		if (Input.GetKey(KeyCode.W))
		{
			transform.position += camera.transform.forward * Time.deltaTime * speed;
		}
		if (Input.GetKey(KeyCode.S))
		{
			transform.position -= camera.transform.forward * Time.deltaTime * speed;
		}
		if (Input.GetKey(KeyCode.A))
		{
			transform.position -= camera.transform.right * Time.deltaTime * speed;
		}
		if (Input.GetKey(KeyCode.D))
		{
			transform.position += camera.transform.right * Time.deltaTime * speed;
		}

		//Vector3 cameraAngles = camera.transform.localEulerAngles;

		//transform.localEulerAngles = new Vector3(this.transform.localEulerAngles.x, cameraAngles.y, this.transform.localEulerAngles.z);
	}
}
