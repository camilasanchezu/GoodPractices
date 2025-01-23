using DesignPatterns.ModelBuilders;
using DesignPatterns.Models;

namespace DesignPatterns.Factories
{
    public class FordMustangFactory: CarFactory
    {
        public override Vehicle Create()
        {
            return new CarModelBuilder() // CarModelBuilder is a class that builds
                .setModel("Mustang") 
                .setColor("red")
                .Build();
        }
    }
}
