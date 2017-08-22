using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TextManager : MonoBehaviour {

    public Text text;
    public bool room1 = false;
    public bool room2 = false;
    public bool room3 = false;
    public bool room4 = false;

    public void Room1() {
        room1 = true;
        room2 = false;
        room3 = false;
        room4 = false;
    }

    public void Room2()
    {
        room1 = false;
        room2 = true;
        room3 = false;
        room4 = false;
    }

    public void Room3()
    {
        room1 = false;
        room2 = false;
        room3 = true;
        room4 = false;
    }

    public void Room4()
    {
        room1 = false;
        room2 = false;
        room3 = false;
        room4 = true;
    }

    private void Update()
    {
        if (room1 == true)
        {
            text.text = "Комната 001";
        }
        else if (room2 == true) {
            text.text = "Комната 002";
        }
        else if (room3 == true)
        {
            text.text = "Комната 003";
        }
        else if (room4 == true)
        {
            text.text = "Комната 004";
        }
    }
}
