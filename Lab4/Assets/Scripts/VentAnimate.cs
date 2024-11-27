using UnityEngine;

public class VentAnimate : MonoBehaviour {

    Animator anim;               
    void Start()
    {
        anim = GetComponent<Animator>();  
    }
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Q))
        {
            anim.SetTrigger("hittenOn");
        }
        if (Input.GetKeyDown(KeyCode.E))
        {
            anim.SetTrigger("hittenOff");
        }
    }
}