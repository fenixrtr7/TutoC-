using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerPattern : MonoBehaviour
{
    ICommand moveUp, moveDown, moveleft, moveRight;
    [SerializeField]
    private float _speed;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.W))
        {
            moveUp = new MoveUpCommand(this.transform, _speed);
            moveUp.Execute();
            CommandManagerMove.Instance.AddCommand(moveUp);
        }
        else if(Input.GetKey(KeyCode.S))
        {
            moveDown = new MoveDownCommand(this.transform, _speed);
            moveDown.Execute();
            CommandManagerMove.Instance.AddCommand(moveDown);
        }
        else if(Input.GetKey(KeyCode.A))
        {
            moveleft = new MoveLeftCommand(this.transform, _speed);
            moveleft.Execute();
            CommandManagerMove.Instance.AddCommand(moveleft);
        }
        else if(Input.GetKey(KeyCode.D))
        {
            moveRight = new MoveRightCommand(this.transform, _speed);
            moveRight.Execute();
            CommandManagerMove.Instance.AddCommand(moveRight);
        }
    }
}
