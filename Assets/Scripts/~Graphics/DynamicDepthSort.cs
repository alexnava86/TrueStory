using UnityEngine;
using System.Collections;

public class DynamicDepthSort : MonoBehaviour 
{
	void Update () 
	{
		GetComponent<Renderer>().sortingOrder = (int)(transform.position.y * -1);	
	}
}
