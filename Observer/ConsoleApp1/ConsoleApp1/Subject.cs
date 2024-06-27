﻿using ConsoleApp1;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2   
{
    public class Subject
    {
        private List<Observer> observers = new List<Observer>();
        private int state;
        public int GetState()
        {
            return state;
        }
        public void SetState(int state)
        {
            this.state = state;
            NotifyAllObservers();
            
        }
        public void Attach(Observer observer)
        {
            observers.Add(observer);
        }
        public void UnAttach(Observer observer)
        {
            observers.Remove(observer);
        }
        public void NotifyAllObservers()
        {
            foreach (Observer observer in observers)
            {
                observer.Update();
            }
        }
    }
}