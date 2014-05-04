
namespace ObservaTerra.Core
{
    public static class CoreFactory
    {
        public static IObservationCore GetObservationCore()
        {
            return new ObservationCore();
        }

        public static IIndicatorCore GetIndicatorCore()
        {
            return new IndicatorCore();
        }

        public static IComponentCore GetComponentCore()
        {
            return new ComponentCore();
        }

        public static IAreaCore GetAreaCore()
        {
            return new AreaCore();
        }
    }
}
