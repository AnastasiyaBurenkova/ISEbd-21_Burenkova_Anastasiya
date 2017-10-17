using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApplication16
{
    class Pan
    {
        private Maslo[] maslo;
        private Potato[] potato;
        private Kabach[] kabach;
        private Perez[] perez;
        private Priprava priprava;
        public bool ReadyToGo { get { return Check(); } }
        public void Init(int countPotato, int countPerez, int countKabach)
        {
            maslo = new Maslo[15];
            potato = new Potato[countPotato];
            kabach = new Kabach[countKabach];
            perez = new Perez[countPerez];
        }
        public void AddMaslo(Maslo m)
        {
            for (int i = 0; i < maslo.Length; ++i)
            {
                if (maslo[i] == null)
                {
                    maslo[i] = m;
                    return;
                }
            }
        }
        public void AddPriprava(Priprava s)
        {
            priprava = s;
        }
        public void AddPotato(Potato p)
        {
            
          
        }
        public void AddPerez(Perez p2)
        {
            
        }
        public void AddKabach(Kabach p3)
        {
            
        }


        private bool Check()
        {
            
            return true;
        }
        public void GetHeat()
        {
            if (!Check())
            {
                return;
            }
            if (maslo.Length>0)
            {
                if(maslo[0].Temperature<100)
                {
                    for (int i=0; i<maslo.Length; ++i)
                    {
                        maslo[i].GetHeat();
                    }
                    bool flag = false;
                    switch (maslo[0].Temperature)
                    {
                        case 20: flag = true; break;
                        case 40: flag = true; break;
                        case 60: flag = true; break;
                        case 80: flag = true; break;
                        case 100: flag = true; break;
                    }
                    if (flag)
                    {
                        for (int i=0; i<potato.Length; ++i)
                        {
                            potato[i].GetHeat();
                        }
                        for (int i = 0; i < perez.Length; ++i)
                        {
                            perez[i].GetHeat();
                        }
                        for (int i = 0; i < kabach.Length; ++i)
                        {
                            kabach[i].GetHeat();
                        }
                    }
                }
                else
                {
                    for (int i=0; i<potato.Length;++i)
                    {
                        potato[i].GetHeat();
                    }
                    for (int i = 0; i < perez.Length; ++i)
                    {
                        perez[i].GetHeat();
                    }
                    for (int i = 0; i < kabach.Length; ++i)
                    {
                        kabach[i].GetHeat();
                    }
                }
            }

        }

        //internal void Init(int v)
        //{
         //   throw new NotImplementedException();
        //}

        /// проверка готовности
        public bool IsReady()
        {
            
            return true;
        }

        internal Potato[] GetPotato()
        {
            throw new NotImplementedException();
        }
    }
}