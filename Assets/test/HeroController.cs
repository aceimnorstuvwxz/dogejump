using UnityEngine;
using System.Collections;

public class HeroController : MonoBehaviour {

	public float my_scale = 0.7f;
	public float jump_speed = 2f;

	// Use this for initialization
	public Rigidbody rb;

	void Start () {
		transform.localScale = new Vector3 (my_scale, my_scale, my_scale);
		rb = GetComponent<Rigidbody>();

	}
	
	// Update is called once per frame
	void Update () {

	
	}

	void OnCollisionEnter (Collision col)
	{
		Debug.Log ("c:");
	}

	public void Test()
	{
		TouchAction (TouchController.TouchActionType.leftright);
	}

	public void TestLeft()
	{
		TouchAction (TouchController.TouchActionType.left);
	}

	public void TestRight()
	{
		TouchAction (TouchController.TouchActionType.right);
	}

	public void TouchAction(TouchController.TouchActionType t)
	{

		bool airJump = rb.velocity.z > 0;
		switch (t) {
		case TouchController.TouchActionType.left:
			Debug.Log ("ta left");
			rb.velocity = new Vector3(-1, 2, 1)*jump_speed;

			break;
			
		case TouchController.TouchActionType.right:
			Debug.Log ("ta right");
			rb.velocity = new Vector3(1, 2, 1)*jump_speed;

			break;
			
		case TouchController.TouchActionType.leftright:
			Debug.Log ("ta leftright");
			rb.velocity = new Vector3(0, 2, 1)*jump_speed;

			break;
		}

		if (airJump) {
			rb.velocity = rb.velocity + new Vector3(0f,1f,0f)*jump_speed;
		}

	}
}
