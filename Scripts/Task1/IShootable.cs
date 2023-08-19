using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public interface IShootable
{
    int Bullets { get; }
    int MaxBulletsInMagazine { get; }
}
