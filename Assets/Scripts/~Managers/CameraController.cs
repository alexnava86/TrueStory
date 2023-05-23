using UnityEngine;
using System.Collections;

public class CameraController : MonoBehaviour
{

	private GameObject player1;
	private GameObject player2;
	private GameObject player3;
	private GameObject player4;
	private Transform player1Pos;
	private Transform player2Pos;
	private Transform player3Pos;
	private Transform player4Pos;
	Transform camPos;

	#region MonoBehaviour
	void Awake ()
	{
		//this.GetComponent<Camera>().main
		camPos = transform;
		player1 = GameObject.FindGameObjectWithTag ("Player");
		player1Pos = player1.transform;
	}
	void Start ()
	{

	}

	void FixedUpdate ()
	{
		if (player1Pos.position.x > camPos.position.x + 150)
		{
			MoveRight ();
		}

		if (player1Pos.position.x < camPos.position.x - 150)
		{
			MoveLeft ();
		}

		if (player1Pos.position.y > camPos.position.y + 48)
		{
			MoveUp ();
		}

		if (player1Pos.position.y < camPos.position.y - 72)
		{
			MoveDown ();
		}
	}

	void LateUpdate ()
	{
		camPos.position = new Vector3 (Mathf.Round (GetComponent<Camera> ().transform.position.x), Mathf.Round (GetComponent<Camera> ().transform.position.y), -10f);
	}
	#endregion

	#region Methods
	public void MoveUp ()
	{
		camPos.position = new Vector2 (camPos.position.x, camPos.position.y + 1f);
	}
	public void MoveDown ()
	{
		camPos.position = new Vector2 (camPos.position.x, camPos.position.y - 1);
	}
	public void MoveRight ()
	{
		camPos.position = new Vector2 (camPos.position.x + 1f, camPos.position.y);

	}
	public void MoveLeft ()
	{
		camPos.position = new Vector2 (camPos.position.x - 1f, camPos.position.y);
	}
	public void SplitScreenHorizontally ()
	{

	}
	public void SplitScreenVertically ()
	{

	}
	#endregion
}
