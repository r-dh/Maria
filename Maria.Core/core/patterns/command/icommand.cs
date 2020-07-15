namespace Maria
{
    namespace Patterns
    {
        public interface ICommand
        {
            bool execute(ICommandReceiver receiver);
        }
    }
}
