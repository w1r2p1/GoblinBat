﻿using System;
using System.Collections.Generic;

using ShareInvest.Catalog.Models;

namespace ShareInvest.EventHandler
{
    public class SendSecuritiesAPI : EventArgs
    {
        public SendSecuritiesAPI(short error) => Convey = error;
        public SendSecuritiesAPI(Codes codes) => Convey = codes;
        public SendSecuritiesAPI(Tuple<string, string> tuple) => Convey = tuple;
        public SendSecuritiesAPI(string code, Stack<string> stack) => Convey = new Tuple<string, Stack<string>>(code, stack);
        public SendSecuritiesAPI(string message) => Convey = message;
        public SendSecuritiesAPI(string[] accounts) => Convey = accounts;
        public SendSecuritiesAPI(string code, string name, string retention, string price, int market) => Convey = new Tuple<string, string, string, string, int>(code, name, retention, price, market);
        public object Convey
        {
            get; private set;
        }
    }
}