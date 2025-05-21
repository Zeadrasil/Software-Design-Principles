using System.Security.Cryptography.X509Certificates;
using UnityEngine;

public class MoveRight : MovementCommand
{
    public MoveRight(IMovable subject) : base(subject)
    {
    }

    public override void Execute()
    {
        subject.ProcessRightButton();
    }
}
