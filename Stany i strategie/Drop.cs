using System;
namespace StateTask
{
    class Drop
    {
        private State state = null;
        private int counterCloud = 0;

  
        public int getCounter()
         {
             if (counterCloud != 3) {
                 counterCloud++;
                 return (counterCloud - 1);
             };
             counterCloud = 0;
             return counterCloud;
         }
        

        public void changeState(State newState)
        {
            state = newState;
        }
        public void Rainfall() {
            state.Rainfall();
        }
        public void Respiration() {
            state.Respiration();
        }
        public void Drinking() {
            state.Drinking();
        }
        public void Evaporation() {
            state.Evaporation();
        }
        public void Inflow() {
            state.Inflow();
        }
        public void Excretion() {
            state.Excretion();
        }
        public void Cleansing() {
            state.Cleansing();
        }
        public string GetStateInfo()
        {
            return state.Info();
        }
    }
}
