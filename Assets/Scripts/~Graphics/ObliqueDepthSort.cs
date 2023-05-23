using UnityEngine;
using System.Collections;

public class ObliqueDepthSort : MonoBehaviour 
{
	private void OnTriggerEnter2D(Collider2D collider)
	{
		if(collider.gameObject.name == "Bottom")
		{
			this.GetComponent<DynamicDepthSort>().enabled = false;
			this.GetComponent<SpriteRenderer>().sortingOrder = collider.gameObject.transform.parent.GetComponent<SpriteRenderer>().sortingOrder + 1;
		}
	}
	private void OnTriggerExit2D(Collider2D collider)
	{
		this.GetComponent<DynamicDepthSort>().enabled = true;
	}
}
