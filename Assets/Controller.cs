using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Controller : MonoBehaviour {

	PointerController l;
	PointerController r;
	GameObject reima;

	void Start () {
		l = GameObject.Find ("L").GetComponent<PointerController> ();
		r = GameObject.Find ("R").GetComponent<PointerController> ();
		reima = GameObject.Find("Reima");
	}
	void Update () {
		if (l.getPressed ()) {
			reima.transform.Translate (-0.1f, 0, 0);
		}
		if (r.getPressed ()) {
			reima.transform.Translate (0.1f, 0, 0);
		}
}
}