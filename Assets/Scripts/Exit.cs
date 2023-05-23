using UnityEngine;
using System.Collections;

public class Exit : MonoBehaviour
{
	public Exit To { get; set; }
	public Exit From { get; set; }

	private void OnTriggerEnter2D ()
	{
		if (To != null)
		{
			//Application.LoadLevel(To);
		}
	}
}
