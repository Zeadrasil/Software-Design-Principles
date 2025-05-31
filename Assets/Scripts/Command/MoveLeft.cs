using System.Security.Cryptography.X509Certificates;
using UnityEngine;

public class MoveLeft : MovementCommand
{
    public MoveLeft(IMovable subject) : base(subject)
    {
    }

    public override void Execute()
    {
        subject.ProcessLeftButton();
    }
}
