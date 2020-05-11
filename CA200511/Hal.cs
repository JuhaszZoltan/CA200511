
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CA200511
{
    class Hal
    {
        public static string[] Fajtak = { "ponty", "harcsa", "busa", "kárasz", "bohóchal", "aranyhal", "keszeg", "polip" };

        public float Suly
        { 
            get { return _suly; }
            set
            {
                if (_suly != 0 &&  value > _suly * 1.1F) 
                    throw new Exception("ennyive egyszerre nem változhat a súlya!");
                if (value < .5F) throw new Exception("túl alacsony a súlya!");
                if (value > 40) throw new Exception("túl magag a súlya!");
                _suly = value;
            }
        }
        private float _suly;

        public bool Ragadozo 
        { 
            get { return _ragadozo; }
            set
            {
                if (_isRagadozoSet) throw new Exception("nem változtatható meg!");
                _isRagadozoSet = true;
                _ragadozo = value;
            }
        }
        private bool _ragadozo;
        private bool _isRagadozoSet = false;

        public int MinMelyseg
        {
            get { return _minMelyseg; }
            set
            {
                if (value < 0) throw new Exception("nem léteznek repülő halak");
                if (value > 400) throw new Exception("nem lehet ilyen mély a minimum");
                _minMelyseg = value;
            }
        }
        private int _minMelyseg;

        public int Merules 
        {
            get { return _merules; } 
            set
            {
                if (value < 10) throw new Exception("nem lehet ilyen szűk a merülési sáv!");
                if (value > 400) throw new Exception("nem lehet ilyen széles a merülési sáv!");
                _merules = value;
            }
        }
        private int _merules;
        public string Faj
        {
            get { return _faj; }
            set
            {
                if (value is null) throw new Exception("nem lehet null!");
                if (value.Length < 3) throw new Exception("túl rövig faj-azonosító!");
                if (value.Length > 30) throw new Exception("túl hosszú faj-azonosító!");
                _faj = value;
            }
        }
        private string _faj;


    }
}
