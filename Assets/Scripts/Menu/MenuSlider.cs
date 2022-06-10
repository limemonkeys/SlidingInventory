using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MenuSlider : MonoBehaviour
{
    public GameObject Menu;
    private bool menuActive;

    // Start is called before the first frame update
    void Start()
    {
        menuActive = false;
    }

    // Update is called once per frame
    void Update()
    {
        if (!menuActive)
        {
            if (Input.GetKeyDown(KeyCode.Escape) && !Menu.GetComponent<PullMenu>().enabled)
            {
                Menu.GetComponent<PullMenu>().ResetVars();
                Menu.GetComponent<PullMenu>().enabled = true;
            }
            if (Menu.GetComponent<PullMenu>().IsFinishedLerp())
            {
                Menu.GetComponent<PullMenu>().enabled = false;
                Menu.GetComponent<PushMenu>().ResetLerp();
                menuActive = true;
            }
        }
        if (menuActive && !Input.GetMouseButton(0)) 
        {
            if (Input.GetKeyDown(KeyCode.Escape))
            {
                if (!Menu.GetComponent<PushMenu>().enabled)
                {
                    Menu.GetComponent<PushMenu>().ResetVars();
                    Menu.GetComponent<PushMenu>().enabled = true;
                }
            }
            if (Menu.GetComponent<PushMenu>().IsFinishedLerp())
            {
                Menu.GetComponent<PushMenu>().enabled = false;
                Menu.GetComponent<PullMenu>().ResetLerp();
                menuActive = false;
                
            }
        }
    }
}
