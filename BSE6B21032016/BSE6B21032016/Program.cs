using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BSE6B21032016
{
    delegate void Del(int a, int b);

    class student<T, U>
    {
        T id;
        U name;

        T ID
        {
            get
            {
                return id;
            }
            set
            {
                id = value;
            }
        }

        U NAME
        {
            get
            {
                return name;
            }
            set
            {
                name = value;
            }
        }

        T GetID()
        {
            return id;
        }
    }

    class calculator<T>
    {
        public T add(T a, T b)
        {
            return a;
        }
    }

    class MyCalc<U>: calculator<U>
    {

    }

    interface intf<T>
    {
        T obj;
    }

    class Program
    {
        static void Main(string[] args)
        {
            calculator<float> obj1 = new calculator<float>();
            calculator<char> obj2 = new calculator<char>();
            MyCalc<float> obj = new MyCalc<float>();
            obj1 = obj;


        }
    }
}
