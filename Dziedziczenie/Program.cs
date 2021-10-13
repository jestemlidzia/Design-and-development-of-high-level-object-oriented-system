using System;

namespace LAB01_Klasy_zad
{
    class Eksponat
    {
        public string Nazwa;
        protected int Rok;
        protected string Autor;
        protected string Opiekun;

        public Eksponat() { }

        public Eksponat(string _nazwa, int _rok, string _autor, string _opiekun)
        {
            this.Nazwa = _nazwa;
            this.Rok = _rok;
            this.Autor = _autor;
            this.Opiekun = _opiekun;
        }

        public void Renowacja(int liczba_dni)
        {
            Console.WriteLine($"Obiekt zostaje poddany renowacji. Nie będzie dostępny przez {liczba_dni} dni.");
        }

        public void Wlaczenie_oswietlenia()
        {
            Console.WriteLine("Obiekt oświetlony.");
        }

        public void Wylaczenie_oswietlenia()
        {
            Console.WriteLine("Obiekt nie oświetlony.");
        }

        public void Zmiana_opiekuna(string _opiekun)
        {
            Console.WriteLine($"{this.Opiekun} zostaje zastapiony przez {_opiekun}.");
            this.Opiekun = _opiekun;
        }
    }

    class Obraz : Eksponat
    {
        protected string Technika_malarska;

        public Obraz() { }

        public Obraz(string _nazwa, int _rok, string _autor, string _opiekun, string _technika_malarska) : base(_nazwa, _rok, _autor, _opiekun)
        {
            this.Technika_malarska = _technika_malarska;
        }

        public void Zmiana_ramy()
        {
            Console.WriteLine("Zmiana ramy obrazu.");
        }
    }

    class Rzezba : Eksponat
    {
        protected string Material;

        public Rzezba() { }

        public Rzezba(string _nazwa, int _rok, string _autor, string _opiekun, string _material) : base(_nazwa, _rok, _autor, _opiekun)
        {
            this.Material = _material;
        }

    }

    class Portret : Obraz
    {
        protected string Model;

        public Portret() { }

        public Portret(string _nazwa, int _rok, string _autor, string _opiekun, string _technika_malarska, string _model) : base(_nazwa, _rok, _autor, _opiekun, _technika_malarska)
        {
            this.Model = _model;
        }

    }

    class Pejzaz : Obraz
    {

        public Pejzaz() { }

        public Pejzaz(string _nazwa, int _rok, string _autor, string _opiekun, string _technika_malarska) : base(_nazwa, _rok, _autor, _opiekun, _technika_malarska) { }

    }

    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Cw_1");

            Eksponat obiektA = new Eksponat("Antyczna misa", 5, "nieznany", "Antoni Nowak");

            Obraz obiektB1 = new Obraz("Bitwa pod Grunwaldem", 1878, "Jan Matejko", "Antoni Nowak", "Olej na płótnie");
            Rzezba obiektB2 = new Rzezba("Dawid", 1504, "Michał Anioł", "Barbara Las", "Marmur");

            Portret obiektC1 = new Portret("Portret Dory Maar", 1937, "Picasso", "Katarzyna K", "Olej na płótnie", "Dora Maar");
            Pejzaz obiektC2 = new Pejzaz("Kuropatwy na śniegu", 1891, "Józef Chełmoński ", "Katarzyna K", "Olej na płótnie");

            obiektA.Renowacja(25);

            obiektB1.Renowacja(8);
            obiektB2.Zmiana_opiekuna("Anna Kot");

            obiektC1.Wlaczenie_oswietlenia();
            obiektC2.Zmiana_ramy();
        }
    }
}
