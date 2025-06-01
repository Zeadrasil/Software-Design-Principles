using System.Text;
using UnityEngine;

public class MirrorAnnouncerDecorator : MonoBehaviour, IAnnouncer
{
    [SerializeField] private IAnnouncer wrappee;
    [SerializeField] private GameObject target;

    public void Announce(string statement)
    {
        StringBuilder stringBuilder = new StringBuilder();
        for(int i = statement.Length - 1; i >= 0; i--)
        {
            stringBuilder.Append(statement[i]);
        }
        wrappee.Announce(stringBuilder.ToString());
    }

    private void Start()
    {
        if(wrappee == null)
        {
            if (target != null)
            {
                wrappee = target.GetComponent<IAnnouncer>();
            }
            else
            {
                wrappee = GameManager.Instance;
            }
        }
    }
}
