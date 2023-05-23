using UnityEngine;
using System.Collections;

public class Player : AbstractCharacter
{
    #region Variables
    private bool running; // Run/ Attack/ Walk/ Idle
    private float speed;
    private Rigidbody2D body;
    private Vector3 location;
    #endregion

    #region MonoBehaviour
    private void Awake()
    {
        base.Awake();
    }

    public void Start()
    {
        base.Start();
        body = this.GetComponent<Rigidbody2D>();
    }

    public void Update()
    {
        //base.Update ();
        if (Input.GetButtonDown("Button1"))
        {

        }
        if (Input.GetButtonDown("Button2"))
        {

        }
        if (Input.GetButtonDown("Button3"))
        {

        }
        if (Input.GetButtonDown("Button4"))
        {

        }

        if (running != false)
        {
            speed = 2f;
            if (Input.GetAxis("Horizontal") != 0)
            {
                if (Input.GetAxis("Horizontal") > 0.5)
                {
                    //runRight
                }
                if (Input.GetAxis("Horizontal") < -0.5)
                {
                    //runLeft
                }
            }
            if (Input.GetAxis("Vertical") != 0)
            {
                if (Input.GetAxis("Vertical") > 0.5)
                {
                    //runUp
                }
                if (Input.GetAxis("Vertical") < -0.5)
                {
                    //runDown
                }
            }
        }
        else
        {
            speed = 1f;
            if (CharAnim != null)
            {
                if (Input.GetAxis("Horizontal") != 0)
                {
                    if (Input.GetAxis("Horizontal") > 0.5)
                    {
                        if (CharAnim.GetBool("WalkRight") == false)
                        {
                            SetAnim("WalkRight");
                        }
                    }
                    else
                    {
                        if (CharAnim.GetBool("WalkRight") == true)
                        {
                            SetAnim("StandRight");
                        }
                    }

                    if (Input.GetAxis("Horizontal") < -0.5)
                    {
                        if (CharAnim.GetBool("WalkLeft") == false)
                        {
                            SetAnim("WalkLeft");
                        }
                    }
                    else
                    {
                        if (CharAnim.GetBool("WalkLeft") == true)
                        {
                            SetAnim("StandLeft");
                        }
                    }
                }
                if (Input.GetAxis("Vertical") != 0)
                {
                    if (Input.GetAxis("Vertical") > 0.5)
                    {
                        SetAnim("WalkUp");
                    }
                    else
                    {
                        if (CharAnim.GetBool("WalkUp") == true)
                        {
                            SetAnim("StandBack");
                        }
                    }
                    if (Input.GetAxis("Vertical") < -0.5)
                    {
                        SetAnim("WalkDown");
                    }
                    else
                    {
                        if (CharAnim.GetBool("WalkDown") == true)
                        {
                            SetAnim("StandFront");
                        }
                    }
                }
            }
        }
    }

    public void FixedUpdate()
    {
        if (Input.GetAxis("Horizontal") != 0 || Input.GetAxis("Vertical") != 0)
        {
            location = new Vector2(this.transform.position.x + speed * Input.GetAxis("Horizontal"), this.transform.position.y + speed * Input.GetAxis("Vertical"));
            body.MovePosition(location);
            //body.AddForce(location);
        }
    }
    #endregion

    #region Methods
    public void OpenMenu()
    {

    }

    public void PauseGame()
    {
        //screen.color = new Color(0.5f, 0.5f, 0.5f, 0.5f);

    }
    #endregion
}
