using System.Collections;
using System.Collections.Generic;
using Assets.Scripts.Controller;
// using Assets.Scripts.Data;
using UnityEngine;

public class GameStarter : MonoBehaviour
{
    [SerializeField] private Data _data;

    private Controllers _Controllers;
    
    // Start is called before the first frame update
    private void Start()
    {
        _Controllers = new Controllers();
        new GameInitialization(_Controllers, _data);
        _Controllers.Initialization();
    }

    // Update is called once per frame
    private void Update()
    {
        var deltaTime = Time.deltaTime;
        _Controllers.Execute(deltaTime);
    }

    private void LateUpdate()
    {
        var deltaTime = Time.deltaTime;
        _Controllers.LateExecute(deltaTime);
    }

    private void OnDestroy()
    {
        _Controllers.Cleanup();
    }
    
}
