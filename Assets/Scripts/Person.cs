using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Person : MonoBehaviour
{
    public float speed;
    public CharacterController controller;
    private Vector3 position;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {   
        // Управление мышкой
        if (Input.GetMouseButton(0))
        {
            // Если игрок кликает по терраруму
            locatePosition();
        }
    }

    void locatePosition()
    {
        RaycastHit Hit;
        Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);

        if (Physics.Raycast(ray, out Hit, 1000)) 
        {
            position = new Vector3(Hit.point.x, Hit.point.y, Hit.point.z);
            Debug.Log(position);
        }
    }

    void moveToPosition() 
    {
        Quaternion newRotation = Quaternion.LookRotation(position - transform.position, Vector3.forward);

        newRotation.x = 0f;
        newRotation.z = 0f;

        transform.rotation = Quaternion.Slerp(transform.rotation, newRotation, Time.deltaTime);
        controller.SimpleMove(transform.forward);
    }
}
