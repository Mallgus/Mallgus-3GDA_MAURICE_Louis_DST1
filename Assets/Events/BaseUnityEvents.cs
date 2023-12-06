using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class BaseUnityEvents : MonoBehaviour
{
    public UnityEvent EventOnAwake;
    public UnityEvent EventOnStart;
    public UnityEvent EventLateUpdate;
    public UnityEvent EventOnEnable;
    public UnityEvent EventOnDisable;


    void Awake()
    {
        EventOnAwake?.Invoke();
    }

    void Start()
    {
        EventOnStart?.Invoke();
    }

    private void LateUpdate()
    {
        EventLateUpdate?.Invoke();
    }

    private void OnEnable()
    {
        EventOnEnable?.Invoke();
    }

    private void OnDisable()
    {
        EventOnDisable?.Invoke();
    }
}
