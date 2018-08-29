/// <summary>
/// 2018.8.29
/// Function: Find other gameobjects.
///
/// Unity3D_2017.3.1f1
///
/// README: Please mount a emptyGameObject, then add a button and 
/// the button add a clieck event, drag the emptyGameObject
/// to the button's click's event
/// </summary>

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class FindOtherGameobjects : MonoBehaviour {

	Scene current_scene;
	GameObject[] objs;  

	void Start()
	{
		SceneManager.SetActiveScene( SceneManager.GetSceneByName( "FaileOfRestart" ) );
	}

	public void FindOtherobjs()
	{
		current_scene = SceneManager.GetActiveScene ();

		if(current_scene.IsValid())
		{
			objs = current_scene.GetRootGameObjects ();

			foreach (GameObject obj in objs)
			{
				if (obj.name != this.name)
				{
					Debug.Log ("Active scene have '" + obj.name + "'.");
				}
			}
		}
	}
}