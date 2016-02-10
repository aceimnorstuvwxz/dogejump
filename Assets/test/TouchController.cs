using UnityEngine;
using System.Collections;

public class TouchController : MonoBehaviour {

	// Use this for initialization
	private HeroController _hero;
	void Start () {
		_hero = GameObject.Find ("Hero").GetComponent<HeroController> ();
	}

	public enum TouchActionType{left, right, leftright};


	private bool touchLeft = false;
	private bool touchRight = false;
	
	// Update is called once per frame
	void Update () {
	

		// release
		if (Input.touchCount == 0 && (touchLeft || touchRight)) {
			if (touchLeft && touchRight) {
				_hero.TouchAction(TouchActionType.leftright);
			} else if (touchLeft) {
				_hero.TouchAction(TouchActionType.left);
			} else if (touchRight) {
				_hero.TouchAction(TouchActionType.right);
			}
			touchLeft = touchRight = false;
		}

		foreach (var th in Input.touches) {
			if (th.position.x < Screen.width*0.5) {
				touchLeft = true;
			} else {
				touchRight = true;
			}
		}

	}
}
