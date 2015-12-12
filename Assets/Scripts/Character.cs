using UnityEngine;
using System.Collections;

public class Character : MonoBehaviour 
{
    public float influence;
    public int health;
    public float speed;

    public string status;

    public bool isLeader;
    public bool isBoss;

    public Transform leader;

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
            default: //Idle

                break;
        }
    }

    public void Follow()
    {
        this.transform.position = Vector3.Lerp(this.transform.position, leader.position, speed/100);
    }
}
