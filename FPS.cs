using System;
using System.Collections.Generic;
using System.Text;

namespace Inheritance_Pelky_Annalesa
{
    class FPS : Game
    {

        public FPS(string esrbParam, string titleParam) : base(esrbParam, titleParam)
        {
            Title = titleParam;
            Esrb = esrbParam;
        }

        public override string Describe()
        {
            return $"{Title} is async fps game rated {Esrb}!";
        }

    }
}
