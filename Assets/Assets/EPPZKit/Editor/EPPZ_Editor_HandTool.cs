#if UNITY_EDITOR
using UnityEngine;
using UnityEditor;
using System.Collections;


[InitializeOnLoad]
public class EPPZ_Editor_HandTool
{


	public static Tool previousTool;
	public static bool spaceIsDown;


	static EPPZ_Editor_HandTool()
	{
		// Register callback.
		SceneView.onSceneGUIDelegate += _OnSceneGUI;
	}

	static void _OnSceneGUI(SceneView sceneView)
	{
		Event event_ = Event.current;
		bool space = (event_.keyCode == KeyCode.Space);

		// If space pressed.
		if (event_.type == EventType.keyDown && space)
		{
			// Save current Tool selection (only at the first event).
			if (spaceIsDown == false) { previousTool = Tools.current; }

			Tools.current = Tool.View; // Set
			Event.current.Use(); // Consume event
			spaceIsDown = true; // Flag
		}

		// If space released.
		if (event_.type == EventType.keyUp && space)
		{
			Tools.current = previousTool; // Set
			Event.current.Use(); // Consume event
			spaceIsDown = false; // Flag
		}
	}
}

#endif