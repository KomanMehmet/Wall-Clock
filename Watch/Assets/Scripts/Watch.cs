using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Watch : MonoBehaviour
{
    [SerializeField] private Transform _second;
    [SerializeField] private Transform _minute;
    [SerializeField] private Transform _hour;

    private float seconds;
    private float minutes;
    private float hours;

    private float _secondDegrees = 6;
    private float _minuteDegrees = 6;
    private float _hourDegrees = 30;


    private void Update()
    {
        seconds += Time.deltaTime;
        minutes += Time.deltaTime / 60;
        hours += Time.deltaTime / 3600;

        _second.transform.localRotation = Quaternion.Euler(new Vector3(seconds * _secondDegrees, 0, 0));
        _minute.transform.localRotation = Quaternion.Euler(new Vector3(minutes * _minuteDegrees, 0, 0));
        _hour.transform.localRotation = Quaternion.Euler(new Vector3(hours * _hourDegrees, 0, 0));
    }
}
