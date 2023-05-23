using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OffsetStaticDepthSort : MonoBehaviour
{
    private void Start()
    {
        GetComponent<Renderer>().sortingOrder = (int)(transform.position.y * -1 + GetComponent<SpriteRenderer>().sprite.pivot.y + GetComponent<SpriteRenderer>().sprite.pivot.y);
    }
}
