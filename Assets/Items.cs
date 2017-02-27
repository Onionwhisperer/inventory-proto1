using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Items : MonoBehaviour {
	bool text;
	public Rect windowRect = new Rect (100, 100, 150, 100);


	List<string> inv = new List<string> ();

	void OnTriggerEnter2D (Collider2D r)
	{
		text = true;
		//Debug.Log (r);
	}
	void OnGUI ()
	{
		windowRect = GUILayout.Window (0, windowRect, DoMyWindow, "Invenotory");
		if (text == true) {
			/*GUI.contentColor = Color.gray;
			GUILayout.BeginArea (new Rect (140, 120, 400, 400));
			GUILayout.BeginVertical ();
			GUILayout.FlexibleSpace ();
			foreach (string item in inv) 
			{
				GUILayout.Label (item);
			}
			GUILayout.FlexibleSpace ();
			GUILayout.EndVertical ();
			GUILayout.EndArea ();
		*/}
			
	}
	void DoMyWindow(int windowID) {
			GUILayout.Box ("moir");
			GUILayout.Box ("keram");
		}
			
	void OnTriggerExit2D (Collider2D r)
	{
		text = false;
		//Debug.Log ("toimii vielä paremmin");
	}
}