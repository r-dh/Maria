namespace Maria
{
    namespace Patterns
    {
        public interface IStateMachine
        {
            void start();
            void update();
            void reset();
            void stop();
        }
    }
}
