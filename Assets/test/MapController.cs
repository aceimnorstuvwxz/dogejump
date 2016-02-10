using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class MapController : MonoBehaviour {
	public GameObject map_node_fab;

	private Dictionary<IntVector3, GameObject> _mapNodes;
	private List<IntVector3> _nodesList;


	void AddNextNode()
	{
		GameObject go = Instantiate<GameObject> (map_node_fab) as GameObject;
		IntVector3 newPosition = new IntVector3 (0, 0, 0);

		if ( _nodesList.Count > 0 ) {
			IntVector3 lastPosition = _nodesList [_nodesList.Count - 1];
			int dx = Random.value < 0.33f ?  -1 : Random.value < 0.33f ? 1 : 0;
			int dy = Random.value < 0.5f ? 1 : 0;

			newPosition = new IntVector3 (lastPosition.x + dx, lastPosition.y + dy, lastPosition.z + 1);
		}

		go.transform.position = newPosition.ToFloat();

		_nodesList.Add (newPosition);
		_mapNodes.Add (newPosition, go);
	}

	void Start () 
	{
		_mapNodes = new Dictionary<IntVector3, GameObject> (new IntVector3.EqualityComparer ());
		_nodesList = new List<IntVector3> ();

		// initly we have some node there!
		for (int i = 0; i < 10; i++) {
			AddNextNode();
		}
	}
	
	void Update () 
	{
	
	}

	// when hit a new node, a new node will add to map,
	// called by hero
	public void Next()
	{
		/*
		if (_nodesList.Count > 0) {
			// delete the last one
			var pos = _nodesList [0];
			_nodesList.RemoveAt (0);
			var go = _mapNodes[pos];
			_mapNodes.Remove(pos);
			Destroy(go);
		}
		*/

		AddNextNode ();
	}
}
