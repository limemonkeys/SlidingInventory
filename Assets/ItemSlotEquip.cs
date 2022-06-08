/* 
    ------------------- Code Monkey -------------------

    Thank you for downloading this package
    I hope you find it useful in your projects
    If you have any questions let me know
    Cheers!

               unitycodemonkey.com
    --------------------------------------------------
 */

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class ItemSlotEquip : MonoBehaviour, IDropHandler {

    public ItemStorage itemStorage;
    public string previousPosition;
    public GameManager gameManager;
    public DragDrop dragDrop;

    public void OnDrop(PointerEventData eventData) {
        if (gameManager.GetPreviousPosition() == null)
        {
            print("previous position: " + gameManager.GetPreviousPosition());
        }
        else
        {
            print("previous position: " + gameManager.GetPreviousPosition().name);
        }
        
        print("this.name: " + this.name);
        if (eventData.pointerDrag != null) {
            eventData.pointerDrag.GetComponent<RectTransform>().anchoredPosition = GetComponent<RectTransform>().anchoredPosition;
            //This hides the object
            //eventData.pointerDrag.SetActive(false);
            if (gameManager.GetPreviousPosition() != null)
            {
                if (gameManager.GetPreviousPosition().tag == "Inventory Storage" && this.gameObject.tag == "Equip Storage" && eventData.pointerDrag.gameObject.GetComponent<DragDrop>().GetIsValidPosition())
                {
                    //itemStorage.PushItem(eventData.pointerDrag.gameObject);
                }
            }
            

            
        }

        gameManager.SetPreviousPosition(this.gameObject);
    }
}
