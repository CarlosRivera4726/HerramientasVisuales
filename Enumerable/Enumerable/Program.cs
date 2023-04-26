// See https://aka.ms/new-console-template for more information
using System;
using System.Collections;

namespace Enumerable {
    public class Color
    {
        public string nombre { get; set; }
    }

    public class Colores : IEnumerable
    {
        private Color[] _colores;
        public Colores(Color[] cArray)
        {
            _colores = new Color[cArray.Length];

            for (int i = 0; i < cArray.Length; i++)
            {
                _colores[i] = cArray[i];
            }
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return (IEnumerator)GetEnumerator();
        }

        public ColoresEnum GetEnumerator()
        {
            return new ColoresEnum(_colores);
        }
    }


    public class ColoresEnum : IEnumerator
    {
        public Color[] _color;

        int position = -1;

        public ColoresEnum(Color[] color)
        {
            _color = color;
        }

        public bool MoveNext()
        {
            position++;
            return (position < _color.Length);
        }

        public void Reset()
        {
            position = -1;
        }

        object IEnumerator.Current
        {
            get
            {
                return Current;
            }
        }

        public Color Current
        {
            get
            {
                try
                {
                    return _color[position];
                }
                catch (IndexOutOfRangeException)
                {
                    throw new InvalidOperationException();
                }
            }
        }
    }


    class Program
    {
        public static void Main()
        {
            Color[] coloresArray = new Color[3]
            {
            new Color(){ nombre="Rojo"},
            new Color(){ nombre="Verde"},
            new Color(){ nombre="Azul"}
            };

            Colores coloresList = new Colores(coloresArray);
            foreach (Color c in coloresList)
            {
                Console.WriteLine(c.nombre);
            }
        }
    }

}

        

