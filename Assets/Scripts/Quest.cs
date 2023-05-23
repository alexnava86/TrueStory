using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class Quest : MonoBehaviour
{
	public bool Completed { get; set; }
	public string Name { get; set; }
	public string Description { get; set; }
	private List<Quest> subQuests = new List<Quest> ();
}
