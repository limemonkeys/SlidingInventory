using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    DragDrop dragDrop;
    public GameObject Inventory;
    private bool inventoryActive;
    private bool pendingHideInventory;
    public GameObject previousPosition;

    // Start is called before the first frame update
    void Start()
    {
        inventoryActive = false;
        pendingHideInventory = false;
        previousPosition = null;
    }

    // Update is called once per frame
    void Update()
    {
        /*
        if (!inventoryActive)
        {
            if (Input.GetKeyDown(KeyCode.Tab) && !Inventory.GetComponent<PullInventory>().enabled)
            {
                Inventory.GetComponent<PullInventory>().ResetVars();
                Inventory.GetComponent<PullInventory>().enabled = true;
            }
            if (Inventory.GetComponent<PullInventory>().IsFinishedLerp())
            {
                Inventory.GetComponent<PullInventory>().enabled = false;
                Inventory.GetComponent<PushInventory>().ResetLerp();
                inventoryActive = true;
            }
        }
        if (inventoryActive && !Input.GetMouseButton(0) || (pendingHideInventory && !Input.GetMouseButton(0))) 
        {
            if (Input.GetKeyDown(KeyCode.Tab) || pendingHideInventory)
            {
                if (!Inventory.GetComponent<PushInventory>().enabled)
                {
                    pendingHideInventory = false;
                    Inventory.GetComponent<PushInventory>().ResetVars();
                    Inventory.GetComponent<PushInventory>().enabled = true;
                }

                
            }
            if (Inventory.GetComponent<PushInventory>().IsFinishedLerp())
            {
                Inventory.GetComponent<PushInventory>().enabled = false;
                Inventory.GetComponent<PullInventory>().ResetLerp();
                inventoryActive = false;
                
            }
        }

        if (inventoryActive && Input.GetKeyDown(KeyCode.Tab) && Input.GetMouseButton(0))
        {
            pendingHideInventory = true;
        }
        */
        if (!inventoryActive)
        {
            if (Input.GetKeyDown(KeyCode.Tab) && !Inventory.GetComponent<PullInventory>().enabled)
            {
                Inventory.GetComponent<PullInventory>().ResetVars();
                Inventory.GetComponent<PullInventory>().enabled = true;
            }
            if (Inventory.GetComponent<PullInventory>().IsFinishedLerp())
            {
                Inventory.GetComponent<PullInventory>().enabled = false;
                Inventory.GetComponent<PushInventory>().ResetLerp();
                inventoryActive = true;
            }
        }
        if (inventoryActive && !Input.GetMouseButton(0)) 
        {
            if (Input.GetKeyDown(KeyCode.Tab))
            {
                if (!Inventory.GetComponent<PushInventory>().enabled)
                {
                    Inventory.GetComponent<PushInventory>().ResetVars();
                    Inventory.GetComponent<PushInventory>().enabled = true;
                }

                
            }
            if (Inventory.GetComponent<PushInventory>().IsFinishedLerp())
            {
                Inventory.GetComponent<PushInventory>().enabled = false;
                Inventory.GetComponent<PullInventory>().ResetLerp();
                inventoryActive = false;
                
            }
        }
    }

    public GameObject GetPreviousPosition()
    {
        return(previousPosition);
    }

    public void SetPreviousPosition(GameObject previousPosition)
    {
        this.previousPosition = previousPosition;
    }
}
