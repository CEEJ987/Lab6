
namespace Lab06
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Rhino rhino = new Rhino();
            rhino.Charge();

            Monkey monkey = new Monkey();
            monkey.Walk();
            monkey.Sleep();
            monkey.ClimbTree();

            Sloth commodoDragon = new Sloth();
            commodoDragon.Sound();
            commodoDragon.Eat();

            Eagle eagle = new Eagle();
            eagle.Fly();

            GeckoLizard gekkoLizard = new GeckoLizard();
            gekkoLizard.Eat();
            gekkoLizard.Sound();


        }
    }
}