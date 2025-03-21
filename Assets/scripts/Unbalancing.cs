using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Unbalancing : MonoBehaviour
{
    public Slider balanceSlider;
    public float MaxBalance = 100f;
    public float offsetY;

    public GameObject parent;

    void Start()
    {
     //Balance = Max (tentar pegar do Player)
     balanceSlider.value = MaxBalance;   
    }

    // Update is called once per frame
    void Update()
    {
        if (parent != null)
                {
                    transform.position = new Vector3(parent.transform.position.x, parent.transform.position.y + offsetY, parent.transform.position.z);
                }
    }

    public void DesBalance(float disturb, float maxBalance){
        float visualDesbalance = (disturb/maxBalance) ;
        balanceSlider.value -= visualDesbalance;
    }

    public void ResetBar(){
        balanceSlider.value = MaxBalance;
    }


}
