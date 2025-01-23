using DesignPatterns.ModelBuilders;
using DesignPatterns.Models;

namespace DesignPatterns.Factories
{
    public class FordEscapeFactory : CarFactory
    {
        public override Vehicle Create() // Factory Method
        {
            return new CarModelBuilder()
                .setModel("Escape")
                .setColor("red")
                .Build();
        }

    }
}
