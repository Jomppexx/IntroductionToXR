using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DoorOpen : MonoBehaviour
{

    [SerializeField] private GameObject blueButton;
    [SerializeField] private GameObject redButton;
    [SerializeField] private GameObject greenButton;
    [SerializeField] private GameObject doorLeft;
    [SerializeField] private GameObject doorRight;

    // Start is called before the first frame update
    void Start()
    {
        doorLeft = GameObject.Find("Door_Left");
        doorRight = GameObject.Find("Door_Right");
        blueButton = GameObject.Find("BlueButton/Push");
        redButton = GameObject.Find("RedButton/Push");
        greenButton = GameObject.Find("GreenButton/Push");
    }

    // Update is called once per frame
    void Update()
    {
        if(blueButton.GetComponent<PhysicsButton>()._isPressed && redButton.GetComponent<PhysicsButton>()._isPressed && greenButton.GetComponent<PhysicsButton>()._isPressed)
        {
            Debug.Log("AMOGUS");
            doorLeft.transform.localPosition = new Vector3(0, 0, 1.329f);
            doorRight.transform.localPosition = new Vector3(0.007935028f, -0.1499473f, -2.942f);
        }
    }
}
