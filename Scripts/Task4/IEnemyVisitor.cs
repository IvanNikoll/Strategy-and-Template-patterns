using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public interface IEnemyVisitor
{
    public void Visit(Orc orc);
    public void Visit(Human human);
    public void Visit(Elf elf);

}
