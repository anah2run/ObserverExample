using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public delegate void EventHandler(BoxScript box);

public class HPHandler : MonoBehaviour
{
    private TextMeshProUGUI textUI_;
    public BoxScript[] Boxes;
    private void Awake()
    {
        textUI_ = GetComponent<TextMeshProUGUI>();
        foreach (var box in Boxes)
        {
            box.DeathNotification += new EventHandler(OnBoxDeath);
        }
    }
    public void OnBoxDeath(BoxScript box)
    {
        textUI_.text = $"{box.name} is dead.";
        //box.DeathNotification(box);
    }
}
