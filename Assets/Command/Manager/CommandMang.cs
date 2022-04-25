using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Linq;
public class CommandMang : MonoBehaviour
{
    static CommandMang _instance;
    public static CommandMang Instance
    {
        get
        {
            if (_instance == null)
                print("Command Manager is null");
            return _instance;
        }
    }

    List<ICommand> commands = new List<ICommand>();

    private void Awake()
    {
        _instance = this;
    }


     public void Add(ICommand command)
    {
        commands.Add(command);
    }

    public void Play()
    {
        StartCoroutine(PlayRoutine());
    }

    IEnumerator PlayRoutine()
    {
        yield return null;
        for(int i = 0; i < commands.Count; i++)
        {
            commands[i].Excute();
            yield return new WaitForSeconds(1);
        }
    }

    public void Rewind()
    {
        StartCoroutine(RewindRoutine());
    }

    IEnumerator RewindRoutine()
    {
       foreach(var command in Enumerable.Reverse(commands))
            {
            command.Undue();
            yield return new WaitForSeconds(1);
        }
    }

    public void Done() 
    {
        var cubes = GameObject.FindGameObjectsWithTag("Cube");
        foreach(var cube in cubes)
        {
            cube.GetComponent<MeshRenderer>().material.color = Color.white;
        }
}

    public void Reset()
    {
        commands.Clear();
    }
}
