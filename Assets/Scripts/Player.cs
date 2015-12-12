using UnityEngine;
using System.Collections;

public class Player : MonoBehaviour 
{
	public float speed = 10;
	public float runSpeed = 15;
	public float enegry;
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
		
		
		transform.Translate(xTrans, 0, zTrans);
	}
}
