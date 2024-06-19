

using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace soru2ntp
{
    // ders classı

    public class ders
    {
        public int id
        {
            get { return id; }
            set { id = value; }
        }

        public string derss
        {
            get { return derss; }
            set { derss = value; }
        }

        public int eğitmenid
        {
            get { return eğitmenid; }
            set { eğitmenid = value; }
        }

        public ders(int id, string derss, int eğitmenid)
        {
            this.id = id;
            this.derss = derss;
            this.eğitmenid = eğitmenid;
        }


    }


    // eğitmen classı

    public class eğitmen
    {
        public int id
        {
            get { return id; }
            set { id = value; }
        }
        public string eğitmenisim
        {
            get { return eğitmenisim; }
            set { eğitmenisim = value; }
        }

        List<ders> verilendersler = new List<ders>();

        public eğitmen(int id, string eğitmenisim)
        {
            this.id = id;
            this.eğitmenisim = eğitmenisim;
        }


        public void dersekle(ders ders)
        {
            verilendersler.Add(ders);

        }

        public void listele() {
            for (int i = 0; i < 20; i++)
            {
                Console.WriteLine(verilendersler[i].derss);
            }

        }
    }


    internal class Program
    {
        static void Main(string[] args)
        {
            eğitmen e = new eğitmen(3, "zehra");
            ders d = new ders(2, "kimya", e.id);

            e.dersekle(d);

            e.listele();

            Console.ReadKey();
        }
    }
}

