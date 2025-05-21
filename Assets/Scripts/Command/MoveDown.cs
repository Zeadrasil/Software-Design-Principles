using System.Security.Cryptography.X509Certificates;
using UnityEngine;

public class MoveDown : MovementCommand
{
    public MoveDown(IMovable subject) : base(subject)
    {
    }

    public override void Execute()
    {
        subject.ProcessDownButton();
    }
}
