using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class Shape : MonoBehaviour
{
    private string m_name;
    protected string Name { get { return m_name; }
        set
        {
            if (value.Contains("A"))
            {
                Debug.LogError("Name cannot contain letter A");
            }
            else
            {
                m_name = value;
            }
        } 
    }
    protected void OnMouseDown()
    {
        Debug.Log("Click " + Name);
    }
}
