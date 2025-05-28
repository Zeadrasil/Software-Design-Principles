using System.Security.Cryptography.X509Certificates;
using UnityEngine;

public class MoveUp : MovementCommand
{
    public MoveUp(IMovable subject) : base(subject)
    {
    }

    public override void Execute()
    {
        subject.ProcessUpButton();
    }
}
