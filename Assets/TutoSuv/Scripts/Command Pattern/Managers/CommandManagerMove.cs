using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Linq;

public class CommandManagerMove : MonoSingleton<CommandManagerMove>
{
    private List<ICommand> _commandBuffer = new List<ICommand>();

    public override void Init()
    {
        base.Init();
    }

    public void AddCommand(ICommand command)
    {
        _commandBuffer.Add(command);
    }

    public void Rewind()
    {
        StartCoroutine(RewindRoutine());
    }

    IEnumerator RewindRoutine()
    {
        Debug.Log("Rewinding...");
        foreach (var command in Enumerable.Reverse(_commandBuffer))
        {
            command.Undue();
            yield return new WaitForEndOfFrame();
        }
        Debug.Log("Finished...");
    }

    public void Play()
    {
        StartCoroutine(PlayRoutine());
    }

    IEnumerator PlayRoutine()
    {
        Debug.Log("Rewinding...");
        foreach (var command in _commandBuffer)
        {
            command.Execute();
            yield return new WaitForEndOfFrame();
        }
        Debug.Log("Finished...");
    }
}
