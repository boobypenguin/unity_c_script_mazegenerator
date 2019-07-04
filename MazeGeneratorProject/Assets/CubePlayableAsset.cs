using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Playables;

[System.Serializable]
public class CubePlayableAsset : PlayableAsset
{

    public override Playable CreatePlayable(PlayableGraph graph,
            GameObject go)
    {
        CubePlayableBehaviour behaviour = new CubePlayableBehaviour();
        behaviour.cubeObject = go;
        ScriptPlayable<CubePlayableBehaviour> playable =
                ScriptPlayable<CubePlayableBehaviour>.Create(graph,
                behaviour);
        return playable;
    }
}
