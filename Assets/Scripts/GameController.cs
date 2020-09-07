using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameController : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {

        ItemTree tree = ItemTree.getInstance();

        foreach (Item i in tree.findRecipes("metal"))
        {
            print(i.ToString());
        }
    }

    // Update is called once per frame
    void Update()
    {
    }
}
