namespace BTLap7._1Cshap
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DongVat.AnCo.Bo b = new DongVat.AnCo.Bo();
            b.ID = "b1";
            b.Name = "linh";
            b.Weight = 60;
            DongVat.AnCo.De d = new DongVat.AnCo.De();
            d.ID = "d1";
            d.Name = "dan";
            d.Weight = 20;
            DongVat.AnCo.Trau tr= new DongVat.AnCo.Trau();
            tr.ID = "tr1";
            tr.Name = "quan";
            tr.Weight = 40;
            DongVat.AnThit.CaSau cs = new DongVat.AnThit.CaSau();
            cs.ID = "cs1";
            cs.Name = "khoc";
            cs.Weight= 20;
            DongVat.AnThit.Ho h = new DongVat.AnThit.Ho();
            h.ID = "h1";
            h.Name = "gammmm";
            h.Weight = 20;
            DongVat.AnThit.SuTu st = new DongVat.AnThit.SuTu();
            st.ID = "st1";
            st.Name = "guuuuuu";
            st.Weight = 20;

            Console.WriteLine("Con bo:");
            Console.WriteLine("\t ID:"+b.ID);
            Console.WriteLine("\t Name:"+b.Name);
            Console.WriteLine("\t Weight"+b.Weight);

            Console.WriteLine("Con bo:");
            Console.WriteLine("\t ID:" + b.ID);
            Console.WriteLine("\t Name:" + b.Name);
            Console.WriteLine("\t Weight" + b.Weight);

            Console.WriteLine("Con trau:");
            Console.WriteLine("\t ID:" + tr.ID);
            Console.WriteLine("\t Name:" + tr.Name);
            Console.WriteLine("\t Weight" + tr.Weight);

            Console.WriteLine("Con de:");
            Console.WriteLine("\t ID:" + d.ID);
            Console.WriteLine("\t Name:" + d.Name);
            Console.WriteLine("\t Weight" + d.Weight);

            Console.WriteLine("Con cá sấu:");
            Console.WriteLine("\t ID:" + cs.ID);
            Console.WriteLine("\t Name:" + cs.Name);
            Console.WriteLine("\t Weight" + cs.Weight);

            Console.WriteLine("Con Hổ:");
            Console.WriteLine("\t ID:" + h.ID);
            Console.WriteLine("\t Name:" + h.Name);
            Console.WriteLine("\t Weight" + h.Weight);

            Console.WriteLine("Con Sư tử:");
            Console.WriteLine("\t ID:" + st.ID);
            Console.WriteLine("\t Name:" + st.Name);
            Console.WriteLine("\t Weight" + st.Weight);

            Console.ReadLine();
        }
    }
}
namespace DongVat
{

    namespace AnCo
    {
        public class Bo
        {
            public string ID { get; set; }
            public string Name { get; set; }
            public int Weight { get; set; }
            public Bo(){}
        }
        public class Trau
        {
            public string ID { get; set; }
            public string Name { get; set; }
            public int Weight { get; set; }
            public Trau() { }
        }
        public class De
        {
            public string ID { get; set; }
            public string Name { get; set; }
            public int Weight { get; set; }
            public De() { }
        }
    }
    namespace AnThit
    {
        public class CaSau
        {
            public string ID { get; set; }
            public string Name { get; set; }
            public int Weight { get; set; }
            public CaSau() { }
        }
        public class Ho
        {
            public string ID { get; set; }
            public string Name { get; set; }
            public int Weight { get; set; }
            public Ho() { }
        }
        public class SuTu
        {
            public string ID { get; set; }
            public string Name { get; set; }
            public int Weight { get; set; }
            public SuTu() { }
        }
    }
}