using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Elf : Enemy
{
    public override void Accept(IEnemyVisitor visitor)
    => visitor.Visit(this);
}
