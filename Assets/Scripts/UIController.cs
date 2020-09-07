using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEditorInternal;
using UnityEngine;
using UnityEngine.Rendering;

public class UIController : MonoBehaviour
{
	bool selected = false;

    // Start is called before the first frame update
    void Start()
    {
	}

    // Update is called once per frame
    void Update()
    {
		Vector2 currentPos = this.transform.position;
		Vector2 mousePos = Input.mousePosition;
		float range = 80f;

		// Grab and drop element
        if (Input.GetMouseButtonDown(0))
        {
            if (Mathf.Abs(currentPos.x - mousePos.x) <= range &&
				Mathf.Abs(currentPos.y - mousePos.y) <= range)
            {
				this.selected = true;
            }
		}

		if (Input.GetMouseButtonUp(0))
		{
			this.selected = false;
		}

        if (selected)
        {
			this.transform.position = Input.mousePosition;
		}


	}



}
