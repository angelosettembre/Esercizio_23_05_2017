using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CowBoyController : MonoBehaviour {

    public GameObject cowBoyCLINT;
    public GameObject cowBoy;

    bool dead1 = false;
    bool dead2 = false;

    public int healthCow1;
    public int healthCow2;

    static bool walkForwardCow1;
    static bool walkBackwardCow1;
    static bool punchCow1;

    static bool walkForwardCow2;
    static bool walkBackwardCow2;
    static bool punchCow2;

    Animator anim;
    //public TextMesh lifeClint;
    //public TextMesh lifeCowboy;

    // Use this for initialization
    void Start () {
        anim = GetComponent<Animator>();
        //lifeClint.text = healthCow1.ToString() + "%";
        //lifeCowboy.text = healthCow2.ToString() + "%";
    }
	
	// Update is called once per frame
	void Update () {
        walkForwardCow1 = Input.GetKey(KeyCode.UpArrow);
        walkBackwardCow1 = Input.GetKey(KeyCode.DownArrow);
        punchCow1 = Input.GetKey(KeyCode.Space);

        walkForwardCow2 = Input.GetKey(KeyCode.W);
        walkBackwardCow2 = Input.GetKey(KeyCode.S);
        punchCow2 = Input.GetKey(KeyCode.X);
        //COWBOY1
        if (walkForwardCow1)
        {
            anim.SetTrigger("walkForward1");
        }

        if (walkBackwardCow1)
        {
            anim.SetTrigger("walkBackward1");
        }

        if (punchCow1)
        {
            anim.SetTrigger("punch1");
        }
        //COWBOY2
        if (walkForwardCow2)
        {
            anim.SetTrigger("walkForward2");
        }

        if (walkBackwardCow2)
        {
            anim.SetTrigger("walkBackward2");
        }

        if (punchCow2)
        {
            anim.SetTrigger("punch2");
        }
    }

    void OnCollisionEnter(Collision collision)
    {
        if(!dead1)
        {
            if (punchCow1 && collision.gameObject.name == cowBoyCLINT.name)
            {
                Debug.Log("PUGNO CLINT");
                healthCow2--;
                //lifeCowboy.text = healthCow2.ToString() + "%";
                Debug.Log("LIFE COWBOY " + healthCow2);
                if (healthCow2 == 0)
                {
                    dead2 = true;
                    checkDead();
                }
            }
        }
        if(!dead2)
        {
            if (punchCow2 && collision.gameObject.name == cowBoy.name)
            {
                Debug.Log("PUGNO COWBOY");
                healthCow1--;
                //lifeClint.text = healthCow1.ToString() + "%";
                Debug.Log("LIFE CLINT " + healthCow1);
                if (healthCow1 == 0)
                {
                    dead1 = true;
                    checkDead();
                }
            }
        }
    }

    void checkDead()
    {
        if (dead1)
        {
            anim.SetTrigger("dead1");
            //lifeClint.text = "MORTO";
            cowBoyCLINT.GetComponent<Rigidbody>().isKinematic = true;
            Debug.Log("MORTE CLINT");
        }
        if (dead2)
        {
            anim.SetTrigger("dead2");
            //lifeCowboy.text = "MORTO";
            cowBoy.GetComponent<Rigidbody>().isKinematic = true;
            Debug.Log("MORTE COWBOY");
        }
    }
}
