using UnityEngine;
using System.Collections;

public class HeroController : MonoBehaviour {

	public float my_scale = 0.7f;

	// Use this for initialization
	void Start () {
		transform.localScale = new Vector3 (my_scale, my_scale, my_scale);

	}
	
	// Update is called once per frame
	void Update () {

	
	}

	void OnCollisionEnter (Collision col)
	{
		Debug.Log ("c:");
	}
}
