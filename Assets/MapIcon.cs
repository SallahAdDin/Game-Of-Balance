using UnityEngine;
using System.Collections;

public class MapIcon : MonoBehaviour {
    public float relativeScale;
	
	// Update is called once per frame
	void Update () {
        transform.localScale = relativeScale * Camera.main.transform.position.z * Vector3.one;
	}
}
