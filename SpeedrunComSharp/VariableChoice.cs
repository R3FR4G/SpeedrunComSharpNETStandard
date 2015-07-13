﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SpeedrunComSharp
{
    public class VariableChoice : IElementWithID
    {
        public string ID { get; private set; }
        public string Value { get; private set; }

        private VariableChoice() { }

        public static VariableChoice Parse(SpeedrunComClient client, KeyValuePair<string, dynamic> choiceElement)
        {
            var choice = new VariableChoice();

            choice.ID = choiceElement.Key;
            choice.Value = choiceElement.Value as string;

            return choice;
        }

        public override int GetHashCode()
        {
            return (ID ?? string.Empty).GetHashCode();
        }

        public override bool Equals(object obj)
        {
            var other = obj as VariableChoice;

            if (other == null)
                return false;

            return ID == other.ID;
        }

        public override string ToString()
        {
            return Value;
        }
    }
}
