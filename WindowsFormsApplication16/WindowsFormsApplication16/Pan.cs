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
            for (int i = 0; i < potato.Length; i++)
            {
                if (potato[i] == null)
                {
                    potato[i] = p;
                    return;
                }
            }


        }
        public void AddPerez(Perez p2)
        {
            for (int i = 0; i < perez.Length; i++)
            {
                if (perez[i] == null)
                {
                    perez[i] = p2;
                    return;
                }
            }
        }
        public void AddKabach(Kabach p3)
        {
            for (int i = 0; i < kabach.Length; i++)
            {
                if (kabach[i] == null)
                {
                    kabach[i] = p3;
                    return;
                }
            }
        }


        private bool Check()
        {
            if (kabach == null)
            {
                return false;
            }
            if (perez == null)
            {
                return false;
            }
            if (potato == null)
            {
                return false;
            }
            for (int o = 0; o < perez.Length; ++o)
            {
                if (perez[o] == null)
                    return false;
            }

            for (int m = 0; m < potato.Length; ++m)
            {
                if (potato[m] == null)
                    return false;
            }
            for (int c = 0; c < kabach.Length; ++c)
            {
                if (kabach[c] == null)
                    return false;
            }

            if (priprava == null)
            {
                return false;

            }
            if (maslo == null)
            {
                return false;

            }

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