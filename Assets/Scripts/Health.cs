using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class Health : MonoBehaviour 
{
	public int startingHealth;
	public Image heartImage;

	public int maxHeartsPerRow;

	private ArrayList hearts = new ArrayList();

	// Width (X) and height (Y) of an heart image with additional blank space
	private float spaceX;
	private float spaceY;

	void Start () 
	{
		spaceX = 2.3f;
		spaceY = 2.3f;

		AddHearts (startingHealth);
	}

	public void AddHearts (int n) 
	{
		for (int i = 0; i < n; i++) 
		{
			Transform heart = ((Image)Instantiate(heartImage)).transform;

			// Add heart image to the canvas
			heart.SetParent(GameObject.Find("Canvas").transform, false);

			// Calculate x and y position of the new heart (in number of hearts)
			int y = Mathf.FloorToInt(hearts.Count/maxHeartsPerRow);
			int x = hearts.Count - y * maxHeartsPerRow;

			Vector2 pos = heart.position;
			pos.x += x * spaceX;
			pos.y += -y * spaceY;

			heart.position = pos;

			// Add heart
			hearts.Add(heart);
		}
	}

	public void LoseHearts(int n)
	{
		for (int i = 0; i < n && i < hearts.Count; i++) 
		{
			int lastIndex = hearts.Count - 1;

			// Destroy the image of the last heart
			Image heartImage = (Image)((Transform)hearts[lastIndex]).GetComponent("Image");
			Destroy(heartImage);

			// Remove the last heart
			hearts.RemoveAt(lastIndex);
		}
	}

	void OnCollisionEnter2D(Collision2D collision) 
	{ 
		if( collision.gameObject.tag == "Ennemy" )
		{
			LoseHearts(1);
		}
	}
}
