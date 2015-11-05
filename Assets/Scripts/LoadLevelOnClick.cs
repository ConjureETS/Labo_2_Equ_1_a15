using UnityEngine;
using System.Collections;

public class LoadLevelOnClick : MonoBehaviour 
{
	public void LoadScene(int level)
	{
		Application.LoadLevel(level);
	}
}
