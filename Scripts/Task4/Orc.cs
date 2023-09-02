using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Orc : Enemy
{
    public override void Accept(IEnemyVisitor visitor)
    => visitor.Visit(this);
}
