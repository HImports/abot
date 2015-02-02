﻿using System;
using Abot.Tests.Unit;
using log4net.Config;
using NUnit.Framework;

namespace Abot.Tests.Integration
{
    [SetUpFixture]
    public class AssemblySetup //: Abot.Tests.Unit.AssemblySetup
    {
        [SetUp]
        public void Setup()
        {
            XmlConfigurator.Configure();

            FiddlerProxyUtil.StartAutoRespond(@"..\..\..\TestResponses.saz");
            Console.WriteLine("Started FiddlerCore to autorespond with pre recorded http responses.");
        }

        [TearDown]
        public void After()
        {
            FiddlerProxyUtil.StopAutoResponding();
            Console.WriteLine("Stopped FiddlerCore");
        }
    }
}
