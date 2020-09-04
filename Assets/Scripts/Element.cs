using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEditorInternal;
using UnityEngine;
using UnityEngine.Rendering;

public class Element : MonoBehaviour
{
	bool selected = false;

	Collider2D colider;
	Camera camera;

    // Start is called before the first frame update
    void Start()
    {
		colider = this.GetComponent<Collider2D>();
		camera = GameObject.Find("Main Camera").GetComponent<Camera>();
	}

    // Update is called once per frame
    void Update()
    {
		Vector2 currentPos = this.transform.position;
		Vector2 mousePos = Input.mousePosition;
		float range = 80f;

		print(Mathf.Abs(currentPos.x - mousePos.x) + " " +
		Mathf.Abs(currentPos.y - mousePos.y));


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
