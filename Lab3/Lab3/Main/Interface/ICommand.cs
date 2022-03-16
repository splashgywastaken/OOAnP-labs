namespace Lab3.Main.Interface
{
    public interface ICommand
    {
        void Execute();
        void Undo();
        void Name();
    }
}
