﻿using System;

namespace DiFuncApp.Services
{
    public class Greeter : ITransientGreeter, IScopedGreeter, ISingletonGreeter
    {
        private readonly Guid _id = Guid.NewGuid();

        public string Greet() => $"Hello World! Greeter Instance: {_id.ToString()}";
    }
}
