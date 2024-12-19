using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Item : MonoBehaviour
{
    public bool canBePickedUp = false;

    public void Use()
    {
        Destroy(this.gameObject);
    }

    public void AddToInv(Inventory inv)
    {
        transform.parent = inv.transform; // move the Item into the heirachy of Inv, where it will not be Inv's child
        inv.AddItem(this);
    }

    private void OnTriggerEnter2D(Collider2D collider)
    {
        if (collider.gameObject.name == "Player" && Input.GetKeyDown(KeyCode.Z))
        {
            AddToInv(collider.gameObject.GetComponent<Inventory>());
            //canBePickedUp = true;
        }
    }

    private void OnTriggerExit2D(Collider2D collider)
    {
        if (collider.gameObject.name == "Player")
        {
            canBePickedUp = false;
        }
    }
}
