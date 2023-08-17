using chairAbstractFactory;
using ChairFactory;

class Program
{
    static void Main()
    {

        Chair chair = new Chair();
        Sofa sofa = new Sofa();
        chair.Sit();
        sofa.Relax();

        //open close principle 
        IChair chair1 = new FutureChair();
        chair1.Sit();
        // chair1.Relax();

    }
}