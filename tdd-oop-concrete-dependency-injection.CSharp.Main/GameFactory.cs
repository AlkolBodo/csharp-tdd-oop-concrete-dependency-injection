﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tdd_oop_concrete_dependency_injection.CSharp.Main
{
    public class GameFactory
    {
        public Game createGame(string name)
        {
            return new Game(name);
        }
    }
}
