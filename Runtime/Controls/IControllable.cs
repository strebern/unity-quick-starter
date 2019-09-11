namespace Common.Controls
{
    public interface IControllable
    {
        bool Enabled
        {
            get;
            set;
        }
        void MapInputs();
    }
}
