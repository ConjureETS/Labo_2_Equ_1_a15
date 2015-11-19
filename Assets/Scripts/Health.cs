using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class Health : MonoBehaviour 
{
	public int startingHealth;
	public Image heartImage;

	public int maxHeartsPerRow;

	private ArrayList hearts = new ArrayList();

	private float spaceX;
	private float spaceY;

	void Start () 
	{
		RectTransform r = heartImage.rectTransform;
		spaceX = r.rect.width;
		spaceY = r.rect.height;
		Debug.Log("spaceX : " + spaceX);
		Debug.Log("spaceY : " + spaceY);
		AddHearts (startingHealth);
	}

	void AddHearts (int n) 
	{
		for (int i = 0; i < n; i++) 
		{
			Transform heart = ((Image)Instantiate(heartImage)).transform;
			heart.SetParent(GameObject.Find("HeartCanvas").transform, false);

			int y = Mathf.FloorToInt(hearts.Count/maxHeartsPerRow);
			int x = hearts.Count - y * maxHeartsPerRow;

			Debug.Log("X : " + x);
			Debug.Log("Y : " + y);

			Vector2 pos = heart.position;
			pos.x += x * spaceX;
			pos.y += y * spaceY;

			Debug.Log("posX : " + pos.x);
			Debug.Log("posY : " + pos.y);

			heart.position = pos;

			hearts.Add(heart);
		}
	}
}
