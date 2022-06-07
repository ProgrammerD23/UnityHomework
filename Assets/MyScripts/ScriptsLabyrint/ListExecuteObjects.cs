using System.Collections;   
using System;
using Object = UnityEngine.Object;

namespace Maze {
    public sealed class ListExecuteObjects : IEnumerator, IEnumerable
    {
        private IExecute[] interactiveObjects;
        private int index = -1;
        private Bonus current;

        public ListExecuteObjects()
        {
            var bonus = Object.FindObjectsOfType<Bonus>();
            for (int i = 0; i < bonus.Length - 1; i++)
            {
                if(bonus[i] is IExecute interactiveObject)
                {
                    AddExecuteObject(interactiveObject);
                }
            }
        }

        public void AddExecuteObject(IExecute execute)
        {
            if(interactiveObjects == null)
            {
                interactiveObjects = new[] { execute };
                return;
            }

            Array.Resize(ref interactiveObjects, Length + 1);
            interactiveObjects[Length - 1] = execute;
        }

        public IExecute this[int index]
        {
            get => interactiveObjects[index];
            private set => interactiveObjects[index] = value;
        }

        public int Length => interactiveObjects.Length;

        public bool MoveNext()
        {
            if (index == interactiveObjects.Length - 1)
            {
                Reset();
                return false;
            }
            index++;
            return true;
        }

        public void Reset() => index = -1;

        public object Current => interactiveObjects[index];
        public IEnumerator GetEnumerator()
        {
            return this;
        }
        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }

    }
}