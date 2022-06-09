using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ItemStorage : MonoBehaviour
{
    public List<GameObject> Items;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void PushItem(GameObject item)
    {
        Items.Add(item);
    }

    public void PopItem(GameObject item)
    {
        Items.Remove(item);
    }
}
