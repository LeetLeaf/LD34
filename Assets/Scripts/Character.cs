using UnityEngine;
using System.Collections;

public class Character : MonoBehaviour 
{
    public float influence;
    public int health;
    public float speed;

	public float followDistance;
	public float safeDistance;
	private float followSmoother;

    public string status;

    public bool isLeader;
    public bool isBoss;

    public Transform leader;
	public Transform target;

    public enum ClanType : int
    { 
        Good = 1,
        Neutral = 0,
        Evil = -1
    };
    public enum Aggerssion : int
    {
        Lawful = 1,
        Neutral = 0,
        Chaotic = -1
    };
	// Use this for initialization
	void Start () 
    {

	}
	
	// Update is called once per frame
    void Update()
    {
        switch (status)
        { 
            case "Follow":
                Follow();
                break;
			case "RunAway":
				RunAway();
				break;
            default: //Idle

                break;
        }
    }

    public void Follow()
    {
		float distance = Vector3.Distance(this.transform.position, leader.position);

		if (distance > followDistance)
		{
			Vector3 travelTo = Vector3.LerpUnclamped(this.transform.position, leader.position, speed * Time.deltaTime);
			travelTo.y = this.transform.position.y;
			this.transform.position = travelTo;
		}
	
    }
	public void RunAway()
	{
		float distance = Vector3.Distance(this.transform.position, leader.position);

		if (distance < safeDistance)
		{
			Vector3 travelTo = Vector3.LerpUnclamped(this.transform.position, leader.position, -speed * Time.deltaTime);
			travelTo.y = this.transform.position.y;
			this.transform.position = travelTo;
		}
	}
}
