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

public class ItemSlot : MonoBehaviour, IDropHandler {
    public InventorySlider gameManager;
    public ItemStorage itemStorage;
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
                if (gameManager.GetPreviousPosition().name == "Equip Slot" && this.gameObject.tag == "Inventory Storage" && eventData.pointerDrag.gameObject.GetComponent<DragDrop>().GetIsValidPosition())
                {
                    //itemStorage.PopItem(eventData.pointerDrag.gameObject);
                }
            }
        }
        

        gameManager.SetPreviousPosition(this.gameObject);
    }
}
