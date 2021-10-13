namespace StateTask
{
    abstract class State
    {

        protected Drop drop;

        public State(Drop drop_)
        {
            drop = drop_;
        }

        public void SetContext(Drop drop_)
        {
            drop = drop_;
        }

        public abstract string Info();
        public abstract void Rainfall();
        public abstract void Respiration();
        public abstract void Drinking();
        public abstract void Evaporation();
        public abstract void Inflow();
        public abstract void Excretion();
        public abstract void Cleansing();
    }
}
