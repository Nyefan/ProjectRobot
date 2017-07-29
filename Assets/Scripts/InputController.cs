using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;

public class InputController : MonoBehaviour
{
    public enum Key
    {
        JUMP,
        WALK_LEFT,
        WALK_RIGHT,
        CROUCH,
        ACTION,
        SPRINT
    }

    private Dictionary<Key, HashSet<KeyCode>> bindings = new Dictionary<Key, HashSet<KeyCode>>();

    // Use this for initialization
    void Start()
    {
        bindings.Add(Key.JUMP, new HashSet<KeyCode> {KeyCode.Space, KeyCode.UpArrow, KeyCode.W});
        bindings.Add(Key.WALK_LEFT, new HashSet<KeyCode> {KeyCode.A, KeyCode.LeftArrow});
        bindings.Add(Key.WALK_RIGHT, new HashSet<KeyCode> {KeyCode.D, KeyCode.RightArrow});
        bindings.Add(Key.CROUCH, new HashSet<KeyCode> {KeyCode.S, KeyCode.LeftControl, KeyCode.C});
        bindings.Add(Key.ACTION, new HashSet<KeyCode> {KeyCode.E, KeyCode.KeypadEnter, KeyCode.Return});
        bindings.Add(Key.SPRINT, new HashSet<KeyCode> {KeyCode.LeftShift});
    }

    public void ReplaceKeybind(Key key, KeyCode toRemove, KeyCode toAdd)
    {
        bindings[key].Remove(toRemove);
        bindings[key].Add(toAdd);
    }

    public void AddKeybind(Key key, params KeyCode[] toAdd)
    {
        foreach (KeyCode code in toAdd)
        {
            bindings[key].Add(code);
        }
    }

    public void RemoveKeybind(Key key, params KeyCode[] toRemove)
    {
        foreach (KeyCode code in toRemove)
        {
            bindings[key].Remove(code);
        }
    }

    public bool GetKey(Key key)
    {
        return bindings[key].Any(Input.GetKey);
    }

    public bool GetKeyDown(Key key)
    {
        return bindings[key].Any(Input.GetKeyDown);
    }

    public bool GetKeyUp(Key key)
    {
        return bindings[key].Any(Input.GetKeyUp);
    }
}