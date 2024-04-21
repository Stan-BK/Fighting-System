using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public interface IEllipse: IGeometry
{
    void Draw(Vector3 pos, Vector3 dir)
    {
        Position = pos;
        Direction = dir;
    }
}
