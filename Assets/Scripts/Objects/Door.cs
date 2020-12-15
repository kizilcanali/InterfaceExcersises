using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Door : MonoBehaviour, IUsable, IInteractable, IInteractWithKey
{
    
    HingeJoint Joint;
    JointLimits MinAngle;
    Quaternion rotationValues;
    
    float Speed = 0.5f; 
    private void Awake()
    {

        Joint = this.GetComponent<HingeJoint>();
        MinAngle = Joint.limits;
        rotationValues = transform.rotation;
       
    }
  
    public void Interact()
    {
        rotationValues.y = -90;
        MinAngle.min = -90;
        Joint.limits = MinAngle;
        
        transform.rotation = Quaternion.Lerp(transform.rotation, rotationValues, Speed * Time.deltaTime);

    }

    public void InteractItem()
    {

        Interact();
        
    }

    public void InteractWithE()
    {

        UIManager.Instance.InteractionText.text = "AÇ";
        UIManager.Instance.InteractionText.gameObject.SetActive(true);

    }
}
