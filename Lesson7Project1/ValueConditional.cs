using System;
using System.Linq;
using System.Collections.Generic;
using System.Text;

namespace Lesson7Project1
{
    delegate bool Check<T, V>(T conditional, out V value);

    class ValueConditional<T, V> where T : Data
    {
        private List<Check<T, V>> checks;

        private V @default;

        public int Count { get => checks.Count; }

        public ValueConditional(V @default, params Check<T, V>[] checks)
        {
            this.checks = new List<Check<T, V>>(checks);
            this.@default = @default;
        }

        public void Add(Check<T, V> check) =>
            checks.Add(check);

        public void Clear() =>
            checks.Clear();

        public void RemoveAt(int index) =>
            checks.RemoveAt(index);

        public bool Remove(Check<T, V> remove) =>
            checks.Remove(remove);

        public V Check(T data)
        {
            V retVal = @default;

            foreach (Check<T, V> check in checks)
                if (check(data, out retVal))
                    break;

            return retVal;
        }
    }
}
