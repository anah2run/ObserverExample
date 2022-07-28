using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ColorUIScript : MonoBehaviour
{
    private Image imageUI_;
    public BoxScript[] Boxes;
    private void Awake()
    {
        imageUI_ = GetComponent<Image>();
        foreach (var box in Boxes)
        {
            box.DeathNotification += new EventHandler(OnBoxDeath);
        }
    }
    public void OnBoxDeath(BoxScript box)
    {
        imageUI_.color = box.GetComponent<SpriteRenderer>().color;
    }
}
