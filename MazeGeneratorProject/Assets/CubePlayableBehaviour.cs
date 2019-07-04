using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Playables;

public class CubePlayableBehaviour : PlayableBehaviour
{
    public GameObject cubeObject;

    public override void OnGraphStart(Playable playable) { }

    public override void OnGraphStop(Playable playable) { }

    public override void OnBehaviourPlay(Playable playable,
            FrameData info)
    {
        if (cubeObject == null) { return; }
        Renderer R = cubeObject.GetComponent<Renderer>();
        Color c = R.material.color;
        c.r = 0f;
        c.g = 1f;
        R.material.color = c;
    }

    public override void OnBehaviourPause(Playable playable,
            FrameData info)
    {
        if (cubeObject == null) { return; }
        Renderer r = cubeObject.GetComponent<Renderer>();
        Color c = r.material.color;
        c.r = 1f;
        c.g = 0f;
        r.material.color = c;
    }

    public override void PrepareFrame(Playable playable,
            FrameData info)
    { }
}
