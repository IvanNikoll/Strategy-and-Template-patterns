using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Human : Enemy
{
    public override void Accept(IEnemyVisitor visitor)
    => visitor.Visit(this);
}
