using DesignPatterns.ModelBuilders;
using DesignPatterns.Models;

namespace DesignPatterns.Factories
{
    public class FordExplorerFactory : CarFactory
    {
        public override Vehicle Create() // Factory Method
        {
            return new CarModelBuilder()
                .setModel("Explorer")
                .setColor("black")
                .Build();
        }

    }
}
