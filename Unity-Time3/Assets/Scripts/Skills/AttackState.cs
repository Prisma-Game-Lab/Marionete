using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AttackState : IState // SIgnifica que essa classe herda de, ou seja tem todas as fun��es dessa classe que ela herda: a extens�o, podendo ser mais espec�ficas, e a implementa��o, podendo ter outras funcionalidades
{
    private BattleController bc; // Criar uma vari�vel do tipo battleController

    public AttackState(BattleController _bc)
    {
        this.bc = _bc;
    }

    public void triggerWaterEffect()
    {
        Debug.Log("AttackAgua");
    }

    public void triggerFireEffect()
    {

    }

    public void triggerEarthEffect()
    {

    }

    public void triggerCureEffect()
    {

    }

    public void triggerPunchEffect()
    {

    }

    public void triggerPierceEffect()
    {

    }

    public void triggerCutEffect()
    {

    }

    public void triggerIntensifyEffect()
    {

    }
}
