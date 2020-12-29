using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class PoliceCarTest : MonoBehaviour
{
    public Transform Target;
    Context context;
    private void Update()
    {
        if (_distance(Target.position, transform.position) > 25)
        {
            context = new Context(new ConcreteStateA());
            context.Request();
        }
        if (_distance(Target.position, transform.position) < 25)
        {
            context = new Context(new ConcreteStateB());
            context.Request();
        }
    }
    //计算距离的方法
    public float _distance(Vector3 trans1, Vector3 trans2)
    {
        float diatance;
        diatance = Vector3.Distance(trans1, trans2);
        return diatance;
    }
}

/// <summary>
/// 警车类，对应模式中的Context类
/// </summary>
public class Context
{
    private State state;

    public Context(State state)
    {
        this.state = state;
    }

    public State State
    {
        get { return state; }
        set
        {
            state = value;
            Debug.Log("当前状态 :" + state.GetType().Name);
        }
    }

    public void Request()
    {
        state.Handle(this);
    }
}

/// <summary>
/// 抽象的警车状态类，相当于State类
/// </summary>
public abstract class State
{
    public abstract void Handle(Context context);
}

/// <summary>
/// 具体状态类, 巡逻模式
/// </summary>
public class ConcreteStateA : State
{
    public override void Handle(Context context)
    {
        Debug.Log("巡逻模式");
        Xunluo();
        context.State = new ConcreteStateB();
    }
    public void Xunluo()
    {
        int index = 1;
        GameObject PCcar = GameObject.Find("PoliceCar_01");
        NavMeshAgent nav = PCcar.GetComponent<NavMeshAgent>();
        GameObject Point = GameObject.Find("Point");
        nav.SetDestination(Point.transform.position);
    }
}

/// <summary>
/// 具体状态类，追击模式
/// </summary>
public class ConcreteStateB : State
{
    NavMeshAgent nav;
    public override void Handle(Context context)
    {
        Debug.Log("追击模式");
        Zhuiji();
        context.State = new ConcreteStateA();
    }

    public void Zhuiji()
    {
        GameObject me = GameObject.Find("PoliceCar_01");
        GameObject Player = GameObject.FindGameObjectWithTag("Player");
        nav = me.GetComponent<NavMeshAgent>();
        nav.SetDestination(Player.transform.position);

    }
}