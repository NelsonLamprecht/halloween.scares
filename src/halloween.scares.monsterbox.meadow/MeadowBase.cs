using Meadow;
using Meadow.Devices;
using Meadow.Logging;

namespace halloween.scares.monsterbox.meadow
{
    public abstract class MeadowBase: App<F7FeatherV1>
    {
        protected Logger Logger { get; } = Resolver.Log;

        protected ServiceCollection Services { get; } = Resolver.Services;

        public MeadowBase() { }
    }
}
