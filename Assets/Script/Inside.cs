﻿using System.Collections;
using UnityEngine;

public class Inside : MonoBehaviour
{
    private const string TAGBALL = "Ball";
    private Coroutine Routine;

    private IEnumerator Oui(GameObject parent)
    {
        Debug.Log("Oui()");
        yield return new WaitForSeconds(.5f);
        Debug.Log("TIME");
        Debug.Log($"Parent: {parent.name}");
        //GetComponent<Rigidbody>().MovePosition(Vector3.up);
    }

    private void Start()
    {}

    private void Update()
    {}

    private void OnTriggerEnter(Collider collider)
    {
        if (collider.tag == TAGBALL)
            this.Routine = StartCoroutine(Oui(transform.parent.gameObject));
    }

    private void OnTriggerStay(Collider collider)
    {
    }

    private void OnTriggerExit(Collider collider)
    {
        if (collider.tag == TAGBALL)
            StopCoroutine(this.Routine);
    }
}