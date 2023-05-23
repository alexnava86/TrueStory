using UnityEngine;
using System.Linq;
using System.Collections;
using System.Collections.Generic;

public class AbstractCharacter : MonoBehaviour
{
    #region Variables
    private string charName;
    private int level = 1;
    private int hp;
    private int mp;
    private int xp;
    private int offense; //strength + 
    private int defense; //
    private int magicOffense;
    private int magicDefense;
    private int attack;
    private int evade;
    private int strength;
    private int vitality;
    private int agility;
    private int intelligence;
    private int spirit;
    private int luck;
    private int karma;
    private float inventoryWeight;
    private float inventoryWeightLimit;
    private Item[] inventory = new Item[20]; //Make into List and check if inventory weight is over limit
    private Item[] equipment = new Item[8]; // array of all the items currently equipped on the character

    //private Weapon rightHand;
    //private Weapon leftHand;
    //private Headwear headEquipment;
    //private Torso torsoEquipment;
    //private Legs legEquipment;
    //private Footwear footEquipment;
    //private Accessory[] accessories = new Accessory[2];
    private Animator charAnim;
    #endregion

    #region Properties
    public string CharName
    {
        get
        {
            return charName;
        }
        set
        {
            charName = value;
        }
    }
    public int Level
    {
        get
        {
            return level;
        }
        set
        {
            level = value;
        }
    }
    public int HP
    {
        get
        {
            return hp;
        }
        set
        {
            hp = value;
        }
    }

    public int MP
    {
        get
        {
            return mp;
        }
        set
        {
            mp = value;
        }
    }

    public int XP
    {
        get
        {
            return xp;
        }
        set
        {
            xp = value;
        }
    }
    public int Offense
    {
        get
        {
            return offense;
        }
        set
        {
            offense = value;
        }
    }

    public int Defense
    {
        get
        {
            return defense;
        }
        set
        {
            defense = value;
        }
    }

    public int MagicOffense
    {
        get
        {
            return magicOffense;
        }
        set
        {
            magicOffense = value;
        }
    }

    public int MagicDefense
    {
        get
        {
            return magicDefense;
        }
        set
        {
            magicDefense = value;
        }
    }

    public int Attack
    {
        get
        {
            return attack;
        }
        set
        {
            attack = value;
        }
    }

    public int Evade
    {
        get
        {
            return evade;
        }
        set
        {
            evade = value;
        }
    }

    public int Strength
    {
        get
        {
            return strength;
        }
        set
        {
            strength = value;
        }
    }

    public int Vitality
    {
        get
        {
            return vitality;
        }
        set
        {
            vitality = value;
        }
    }

    public int Agility
    {
        get
        {
            return agility;
        }
        set
        {
            agility = value;
        }
    }

    public int Intelligence
    {
        get
        {
            return intelligence;
        }
        set
        {
            intelligence = value;
        }
    }

    public int Spirit
    {
        get
        {
            return spirit;
        }
        set
        {
            spirit = value;
        }
    }

    public int Luck
    {
        get
        {
            return luck;
        }
        set
        {
            luck = value;
        }
    }
    public int Karma
    {
        get
        {
            return karma;
        }
        set
        {
            karma = value;
        }
    }


    public Animator CharAnim
    {
        get
        {
            return charAnim;
        }
        set
        {
            charAnim = value;
        }
    }

    public Item[] Inventory
    {
        get
        {
            return inventory;
        }
        set
        {
            inventory = value;
        }
    }

    public Item[] Equipment
    {
        get
        {
            return equipment;
        }
        set
        {
            equipment = value;
        }
    }
    #endregion

    #region MonoBehaviour
    public void Awake()
    {
        if (this.gameObject.GetComponent<Animator>() != null)
        {
            charAnim = this.gameObject.GetComponent<Animator>();
        }
    }
    protected void Start()
    {

    }
    protected void Update()
    {

    }
    protected void FixedUpdate()
    {

    }
    public void LateUpdate()
    {
        this.transform.position = new Vector2(Mathf.Round(this.transform.position.x), Mathf.Round(this.transform.position.y));
    }
    #endregion

    #region Methods
    public void SetAnim(string animName)
    {
        if (this.GetComponent<Animator>() != null)
        {
            Animator anim = this.GetComponent<Animator>();
            IEnumerable<string> state = from s in anim.parameters where s.name != animName select s.name;

            foreach (string s in state)
            {
                anim.SetBool(s, false);
            }
            anim.SetBool(animName, true);
        }
    }
    #endregion
}
