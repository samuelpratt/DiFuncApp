﻿using Microsoft.Extensions.Logging;

namespace DiFuncApp.Services
{
    public class LoggingGreeter
    {
        private readonly ILogger _logger;

        public LoggingGreeter(ILogger logger) => _logger = logger;

        public void Greet() => _logger.LogInformation("Hello World!");
    }
}
