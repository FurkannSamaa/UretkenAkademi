using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Move : MonoBehaviour
{
    public float speed=3f;
    void Update()
    {

        Vector3 playerInput = new Vector3(Input.GetAxisRaw("Horizontal"),0f, Input.GetAxisRaw("Vertical"));
        Vector3 Move = playerInput*speed*Time.deltaTime;
        transform.Translate(Move);

    }
}
