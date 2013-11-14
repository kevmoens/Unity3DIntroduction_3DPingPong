﻿using UnityEngine;
using System.Collections;

/// <summary>
/// This behaviour should only exists once in the level and can be attached to any GameObject.
/// It displays the score at the top center of the sreen.
/// </summary>
public class ScoreUI : MonoBehaviour {
	
	/// <summary>
	/// Current score of the right player.
	/// </summary>
	public int scorePlayerRight;
	/// <summary>
	/// Current score of the left player.
	/// </summary>
	public int scorePlayerLeft;
	/// <summary>
	/// Style that is used to display the score text.
	/// </summary>
	public GUIStyle style;
	
	void OnGUI()
	{
		// calculate the top screen center of the screen
		float x = Screen.width/2f;
		float y = 30f;
		float width = 300f;
		float height = 20f;
		string text = scorePlayerLeft + " / " + scorePlayerRight;
		
		// draw the label at the top center of the screen
		GUI.Label(new Rect(x-(width/2f), y, width, height), text, style);
	}
}
