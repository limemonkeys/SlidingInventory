using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShopSlider : MonoBehaviour
{
    public GameObject Shop;
    private bool shopActive;
    private bool pendingHideInventory;

    // Start is called before the first frame update
    void Start()
    {
        shopActive = false;
        pendingHideInventory = false;
    }

    // Update is called once per frame
    void Update()
    {
        if (!shopActive)
        {
            if (Input.GetKeyDown(KeyCode.X) && !Shop.GetComponent<PullShop>().enabled)
            {
                Shop.GetComponent<PullShop>().ResetVars();
                Shop.GetComponent<PullShop>().enabled = true;
            }
            if (Shop.GetComponent<PullShop>().IsFinishedLerp())
            {
                Shop.GetComponent<PullShop>().enabled = false;
                Shop.GetComponent<PushShop>().ResetLerp();
                shopActive = true;
            }
        }
        if (shopActive && !Input.GetMouseButton(0)) 
        {
            if (Input.GetKeyDown(KeyCode.X))
            {
                if (!Shop.GetComponent<PushShop>().enabled)
                {
                    Shop.GetComponent<PushShop>().ResetVars();
                    Shop.GetComponent<PushShop>().enabled = true;
                }
            }
            if (Shop.GetComponent<PushShop>().IsFinishedLerp())
            {
                Shop.GetComponent<PushShop>().enabled = false;
                Shop.GetComponent<PullShop>().ResetLerp();
                shopActive = false;
                
            }
        }
    }
}
