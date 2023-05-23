using UnityEngine;
using System.Collections;

public class StaticDepthSort : MonoBehaviour 
{
	private void Start () 
	{
		GetComponent<Renderer>().sortingOrder = (int)(transform.position.y * -1);
	}
}
