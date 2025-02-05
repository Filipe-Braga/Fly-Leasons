using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class theFloorIsLava : MonoBehaviour
{
    [SerializeField] private float towerX, towerY;
    [SerializeField] private LayerMask Ground;
    private BoxCollider2D boxcol;

    void Start()
    {
        boxcol = GetComponent<BoxCollider2D>();
    }


    void Update()
    {
        if(onLava()){
            transform.position = new Vector3(towerX,towerY,0);
        }
    }

    private bool onLava() 
    {
        RaycastHit2D raycastHit = Physics2D.BoxCast(boxcol.bounds.center, boxcol.bounds.size, 0, Vector2.down, 0.1f, Ground );
        return raycastHit.collider != null;
    }
}
