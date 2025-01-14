using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Orbit : MonoBehaviour
{
    float XAngleValue;
    float YAngleValue;

    [SerializeField] private float xSpeed;
    [SerializeField] private float ySpeed;
    [SerializeField] private float xRadius = 4;
    [SerializeField] private float yRadius = 4;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        XAngleValue += Time.deltaTime * xSpeed;
        YAngleValue += Time.deltaTime * ySpeed;
        this.transform.position = new Vector3(Mathf.Cos(XAngleValue) * xRadius, this.transform.position.y, Mathf.Sin(YAngleValue) * yRadius);
    }
}
