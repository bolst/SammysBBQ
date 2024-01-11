namespace SammysBBQ.Data
{
    public abstract class AbstractController<ControllerType> where ControllerType : new()
    {
        static AbstractController() { }

        private static readonly ControllerType instance = new ControllerType();

        public static ControllerType Instance { get { return instance; } }
    }
}
