using System;

namespace oop
{
    interface IAnimal { }

    interface ITalker : IAnimal
    {
        void Talk();
    }

    interface IWalker : IAnimal
    {
        void Walk();
    }

    interface ISwimer : IAnimal
    {
        void Swim();
    }

    interface IAction : IAnimal
    {
        void DoAction();
    }

    class TalkAction : IAction
    {
        public void DoAction()
        {
            Console.WriteLine("Talk");
        }
    }

    class WalkAction : IAction
    {
        public void DoAction()
        {
            Console.WriteLine("Walk");
        }
    }

    class SwimAction : IAction
    {
        public void DoAction()
        {
            Console.WriteLine("Swim");
        }
    }

    class Pinguin : IAnimal, ISwimer, IWalker
    {
        IAction walkAction;
        IAction swimAction;

        public Pinguin()
        {
            walkAction = new WalkAction();
            swimAction = new SwimAction();
        }

        public void Swim()
        {
            swimAction.DoAction();
        }

        public void Walk()
        {
            walkAction.DoAction();
        }
    }

    class Elephan : IAnimal, IWalker, ITalker
    {
        IAction talkAction;
        IAction walkAction;

        public Elephan()
        {
            talkAction = new TalkAction();
            walkAction = new WalkAction();
        }

        public void Talk()
        {
            talkAction.DoAction();
        }

        public void Walk()
        {
            walkAction.DoAction();   
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            
        }
    }
}
