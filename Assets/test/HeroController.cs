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

	public void TouchAction(TouchController.TouchActionType t)
	{
		switch (t) {
		case TouchController.TouchActionType.left:
			Debug.Log ("ta left");
			rb.velocity = new Vector3(-1, 1, 1)*jump_speed;

			break;
			
		case TouchController.TouchActionType.right:
			Debug.Log ("ta right");
			rb.velocity = new Vector3(1, 1, 1)*jump_speed;

			break;
			
		case TouchController.TouchActionType.leftright:
			Debug.Log ("ta leftright");
			rb.velocity = new Vector3(0, 1, 1)*jump_speed;

			break;
		}
	}
}
